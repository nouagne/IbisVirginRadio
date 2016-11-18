using System;

namespace MRM.Ibis.VirginRadioTour.Core.Exceptions
{
    /// <summary>
    /// Représente les erreurs qui se produisent lorsqu'une erreur a été trouvé.
    /// </summary>
    public class EmailAlreadyExistsException : Exception
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe ErrorFoundException.
        /// </summary>
        public EmailAlreadyExistsException()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe ErrorFoundException avec un message d'erreur spécifié.
        /// </summary>
        /// <param name="message">Message décrivant l'erreur.</param>
        public EmailAlreadyExistsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe ErrorFoundException avec un message d'erreur spécifié et une référence à l'exception interne ayant provoqué cette exception.
        /// </summary>
        /// <param name="message">Message d'erreur indiquant la raison de l'exception.</param>
        /// <param name="innerException">Exception qui constitue la cause de l'exception actuelle.</param>
        public EmailAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
