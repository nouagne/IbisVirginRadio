using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.Core.Exceptions;
using System;
using System.Net.Mail;

namespace MRM.Ibis.VirginRadioTour.Core.BLL
{
    /// <summary>
    /// Représente le gestionnaire de l'entité Participant.
    /// </summary>
    public class ParticipationManager
    {
        private readonly DAL.IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initialise une nouvelle instance de la classe ParticipantManager.
        /// </summary>
        public ParticipationManager()
            : this(new Core.DAL.UnitOfWork(new Core.DAL.EFDbContext()))
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe ParticipantManager à l'aide d'un UnitOfWork.
        /// </summary>
        /// <param name="context"></param>
        public ParticipationManager(DAL.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Enregistre une participation au jeu concours
        /// </summary>
        /// <param name="participation"></param>
        public Participation Participate(Participation participation)
        {
            if (_unitOfWork.ParticipantRepository.Any(p => p.Email == participation.Email && p.EventId == participation.EventId))
                throw new EmailAlreadyExistsException("Cet email a déjà été utilisé");

            _unitOfWork.ParticipantRepository.Add(participation);
            _unitOfWork.SaveChanges();

            return participation;
        }

        /// <summary>
        /// Recherche d'une participation permettant d'accéder ou non au formulaire de validation
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="participationId"></param>
        /// <param name="participationUID"></param>
        /// <returns></returns>
        public Participation Find(string eventId, int participationId, Guid participationUID)
        {
            var participation = _unitOfWork.ParticipantRepository.Find(p => p.EventId == eventId && p.Id == participationId && p.UID == participationUID);
                
            if (participation == null)
                throw new ParticipationNotFoundException("Cette participation n'existe pas");

            return participation;

        }

        /// <summary>
        /// Valide la participation à un événement
        /// </summary>
        public Participation Validate(string eventId, Participation p)
        {
            var participation = _unitOfWork.ParticipantRepository.Find(pa => pa.EventId == eventId && pa.Id == p.Id && pa.UID == p.UID);

            if (participation == null)
                throw new ParticipationNotFoundException("Cette participation n'existe pas");

            participation.Gender = p.Gender;
            participation.Lastname = p.Lastname;
            participation.Firstname = p.Firstname;
            //participation.Email = p.Email;
            participation.Phone = p.Phone;
            participation.Guest = p.Guest;
            participation.ValidationDate = DateTime.Now;

            _unitOfWork.SaveChanges();

            //Envoi du mail d'invitation
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(participation.Email);
            Tools.Email.Send(mailMessage, "Invitation", participation);

            return participation;
        }

        public void DeclareWinner(string eventId, int participationId, Guid participationUID)
        {
            var participation = _unitOfWork.ParticipantRepository.Find(p => p.EventId == eventId && p.Id == participationId && p.UID == participationUID);

            if (participation == null)
                throw new ParticipationNotFoundException("Cette participation n'existe pas");

            if (!participation.IsWinner)
            {
                participation.IsWinner = true;

                _unitOfWork.SaveChanges();

                //Envoi du mail au gagnant
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(participation.Email);
                Tools.Email.Send(mailMessage, "WinningParticipation", participation);
            }
        }
    }
}
