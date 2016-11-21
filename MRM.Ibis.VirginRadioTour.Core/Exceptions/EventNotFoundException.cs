using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM.Ibis.VirginRadioTour.Core.Exceptions
{
    /// <summary>
    /// Représente les erreurs qui se produisent lorsqu'une erreur a été trouvé.
    /// </summary>
    public class EventNotFoundException : Exception
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe EventNotFoundException.
        /// </summary>
        public EventNotFoundException()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe EventNotFoundException avec un message d'erreur spécifié.
        /// </summary>
        /// <param name="message">Message décrivant l'erreur.</param>
        public EventNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe EventNotFoundException avec un message d'erreur spécifié et une référence à l'exception interne ayant provoqué cette exception.
        /// </summary>
        /// <param name="message">Message d'erreur indiquant la raison de l'exception.</param>
        /// <param name="innerException">Exception qui constitue la cause de l'exception actuelle.</param>
        public EventNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
