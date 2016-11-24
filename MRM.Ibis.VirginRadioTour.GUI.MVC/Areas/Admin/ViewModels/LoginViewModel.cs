using MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.ViewModels
{
    public class LoginViewModel
    {
        [Required, Email]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}