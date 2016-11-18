using System.ComponentModel.DataAnnotations;

namespace MRM.Ibis.VirginRadioTour.Core.BO
{
    public enum Gender : int
    {
        [Display(Name = "Mr", ResourceType = typeof(Resources.Genders))]
        Mr = 1,
        [Display(Name = "Mrs", ResourceType = typeof(Resources.Genders))]
        Mrs = 2,
    }
}

