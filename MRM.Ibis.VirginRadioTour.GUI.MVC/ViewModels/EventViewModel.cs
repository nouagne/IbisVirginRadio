using System;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels
{
    public class EventViewModel
    {
        public int? Id { get; set; }

        public string City { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime InscriptionsStartDate { get; set; }

        public DateTime InscriptionsEndDate { get; set; }
    }
}