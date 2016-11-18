using System.Data.Entity;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Représente un contexte
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe UnitOfWork à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }
        
        private IParticipantRepository _participantRepository;

        /// <summary>
        /// Obtient le Repository correspondant à l'entité Entity
        /// </summary>
        public IParticipantRepository ParticipantRepository
        {
            get
            {
                if (this._participantRepository == null)
                {
                    this._participantRepository = new ParticipantRepository(_context);
                }
                return this._participantRepository;
            }
        }

        /// <summary>
        /// Methode pour la sauvegarde unifiée du contexte
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Methode pour la libération du contexte
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
