using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRM.Ibis.VirginRadioTour.Core.BO
{
    /// <summary>
    /// Répresente un évennement VirginRadioTour
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe Event
        /// </summary>
        public Event()
        {

        }

        /// <summary>
        /// Id de l'évennement
        /// </summary>
        [Column("EventId")]
        public int Id { get; set; }

        /// <summary>
        /// Ville
        /// </summary>
        [Column("City")]
        public string City { get; set; }

        /// <summary>
        /// Date de début de l'event
        /// </summary>
        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Date de fin de l'évennement
        /// </summary>
        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Date de début des inscriptions
        /// </summary>
        [Column("InscriptionsStartDate")]
        public DateTime InscriptionsStartDate { get; set; }

        /// <summary>
        /// Date de fin des inscriptions
        /// </summary>
        [Column("InscriptionsEndDate")]
        public DateTime InscriptionsEndDate { get; set; }



    }
}
