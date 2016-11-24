using System;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Fournit une classe d'interface pour le pattern UnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Classe d'interface pour le UserRepository
        /// </summary>
        IUserRepository UserRepository { get; }

        /// <summary>
        /// Classe d'interface pour le RoleRepository
        /// </summary>
        IRoleRepository RoleRepository { get; }

        /// <summary>
        /// Classe d'interface pour le UserRoleRepository
        /// </summary>
        IUserRoleRepository UserRoleRepository { get; }

        /// <summary>
        /// Methode pour la sauvegarde unifiée du contexte
        /// </summary>
        void SaveChanges();
    }
}
