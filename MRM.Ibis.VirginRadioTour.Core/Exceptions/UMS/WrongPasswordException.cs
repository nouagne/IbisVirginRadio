﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM.UMS.Core.Exceptions
{
    public class WrongPasswordException : Exception
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe WrongPasswordException.
        /// </summary>
        public WrongPasswordException()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe WrongPasswordException avec un message d'erreur spécifié.
        /// </summary>
        /// <param name="message">Message décrivant l'erreur.</param>
        public WrongPasswordException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe WrongPasswordException avec un message d'erreur spécifié et une référence à l'exception interne ayant provoqué cette exception.
        /// </summary>
        /// <param name="message">Message d'erreur indiquant la raison de l'exception.</param>
        /// <param name="innerException">Exception qui constitue la cause de l'exception actuelle.</param>
        public WrongPasswordException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
