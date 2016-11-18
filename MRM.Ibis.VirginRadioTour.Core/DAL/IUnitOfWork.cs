using System;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Définit des méthodes pour manipuler les Repository.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Obtient le Repository correspondant à l'entité Entity
        /// </summary>
        IParticipantRepository ParticipantRepository { get; } 

        /// <summary>
        /// Methode pour la sauvegarde unifiée du contexte
        /// </summary>
        void SaveChanges();
    }
}
