using System;
using System.Linq;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Manage UserRole within a db context
    /// </summary>
    public class UserRoleRepository : GenericRepository<BO.UserRole>, IUserRoleRepository
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe UserRoleRepository à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public UserRoleRepository(EFDbContext context)
            : base(context)
        {
            _context = context;
        }

        public bool Exists(int userId, string roleName)
        {
            BO.Role role = _context.Set<BO.Role>().SingleOrDefault(r => r.Name.Equals(roleName, StringComparison.InvariantCultureIgnoreCase));
            if (role == null)
                return false;
            return _context.Set<BO.UserRole>().Any(ur => ur.UserId == userId && ur.RoleId == role.Id);
        }
    }
}
