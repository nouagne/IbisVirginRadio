using System;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Pattern Unit of Work
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe UnitOfWork à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        private IUserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (this._userRepository == null)
                {
                    this._userRepository = new UserRepository(_context);
                }
                return this._userRepository;
            }
        }

        private IRoleRepository _roleRepository;

        public IRoleRepository RoleRepository
        {
            get
            {
                if (this._roleRepository == null)
                {
                    this._roleRepository = new RoleRepository(_context);
                }
                return this._roleRepository;
            }
        }

        private IUserRoleRepository _userRoleRepository;

        public IUserRoleRepository UserRoleRepository
        {
            get
            {
                if (this._userRoleRepository == null)
                {
                    this._userRoleRepository = new UserRoleRepository(_context);
                }
                return this._userRoleRepository;
            }
        }

        /// <summary>
        /// Methode pour la sauvegarde unifiée du contexte
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Methode pour la libération du contexte
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
