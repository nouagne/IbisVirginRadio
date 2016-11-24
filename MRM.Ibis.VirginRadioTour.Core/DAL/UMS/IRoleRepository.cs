using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Fournit une interface de RoleRepository pour le pattern UnitOfWork
    /// </summary>
    public interface IRoleRepository : IGenericRepository<BO.Role>
    {
        List<BO.Role> GetForUser(int userId);
    }
}
