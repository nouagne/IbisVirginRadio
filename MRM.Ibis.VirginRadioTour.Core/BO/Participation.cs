
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Linq;
using System.Web;
using System.Net.Sockets;

namespace MRM.Ibis.VirginRadioTour.Core.BO
{
    /// <summary>
    /// Répresente un Participant
    /// </summary>
    public class Participation
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe Participant
        /// </summary>
        public Participation()
        {
            UID = Guid.NewGuid();
            ParticipationDate = DateTime.Now;
            IsWinner = false;
            IpAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        /// <summary>
        /// Identifiant de l'entité
        /// </summary>
        [Column("ParticipationId")]
        public int Id { get; set; }

        /// <summary>
        /// UID du participant
        /// </summary>
        [Column("ParticipationUID")]
        public Guid UID { get; set; }

        /// <summary>
        /// Identifiant de l'évenement
        /// </summary>
        [Column("EventId")]
        public string EventId { get; set; }

        /// <summary>
        /// Nom du participant
        /// </summary>
        [Column("Firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// Prénom du participant
        /// </summary>
        [Column("Lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// Civilité
        /// </summary>
        [Column("Gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Column("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Téléphone
        /// </summary>
        [Column("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Nom complet de l'accompagnant
        /// </summary>
        [Column("Guest")]
        public string Guest { get; set; }

        /// <summary>
        /// Indique si la participation esta gagnante ou non
        /// </summary>
        [Column("IsWinner")]
        public bool IsWinner { get; set; }

        /// <summary>
        /// Règlement
        /// </summary>
        [Column("Terms")]
        public bool Terms { get; set; }

        /// <summary>
        /// Offres commerciales
        /// </summary>
        [Column("Offers")]
        public bool Offers { get; set; }

        /// <summary>
        /// Date de participation
        /// </summary>
        [Column("ParticipationDate")]
        public DateTime ParticipationDate { get; set; }

        /// <summary>
        /// Date de validation
        /// </summary>
        [Column("ValidationDate")]
        public DateTime? ValidationDate { get; set; }

        /// <summary>
        /// Adresse IP
        /// </summary>
        [Column("IpdAdress")]
        public string IpAddress { get; set; }
    }
}
