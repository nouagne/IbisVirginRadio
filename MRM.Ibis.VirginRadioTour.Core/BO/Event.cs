using System;

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
        public int Id { get; set; }

        /// <summary>
        /// Ville
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
    }
}
