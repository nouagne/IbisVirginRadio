using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes
{
    /// <summary>
    /// Spécifie qu'une valeur de champ de données doit correspondre à un bool vérifiant la condition True
    /// </summary>
    public class TrueAttribute : ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            if (value is bool)
                return (bool)value;
            else
                return false;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
                ValidationType = "true"
            };
        }
    }
}