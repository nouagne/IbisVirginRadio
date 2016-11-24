using System.Collections.Generic;
using System.Linq;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Manage Roles within a db context
    /// </summary>
    public class RoleRepository : GenericRepository<BO.Role>, IRoleRepository
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe RoleRepository à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public RoleRepository(EFDbContext context)
            : base(context)
        {
            _context = context;
        }

        public List<BO.Role> GetForUser(int userId)
        {
            IEnumerable<int> roleIds = _context.Set<BO.UserRole>().Where(ur => ur.UserId == userId).Select(ur => ur.RoleId);
            List<BO.Role> roles = _context.Set<BO.Role>().Where(r => roleIds.Contains(r.Id)).ToList();
            return roles;
        }
    }
}
