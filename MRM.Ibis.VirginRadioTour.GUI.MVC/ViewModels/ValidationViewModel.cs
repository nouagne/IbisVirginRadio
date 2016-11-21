using MRM.Ibis.VirginRadioTour.Core.BO;
using System;
using System.ComponentModel.DataAnnotations;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels
{
    public class ValidationViewModel
    {
        public string EventId { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        public Guid UID { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"0[1-9](\s?\d{2}){4}")]
        public string Phone { get; set; }

        [Required]
        public string Guest { get; set; }
    }
}