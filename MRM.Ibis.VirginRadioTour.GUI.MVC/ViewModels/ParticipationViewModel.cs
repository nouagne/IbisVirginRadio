using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels
{
    public class ParticipationViewModel
    {

        public string EventId { get; set; }

        [Required]
        public Gender? Gender { get; set; }
        
        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"0[1-9](\s?\d{2}){4}")]
        public string Phone { get; set; }

        [Required, True]
        public bool Agreement { get; set; }

        public bool Offers { get; set; }
    }
}