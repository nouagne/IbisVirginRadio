namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Fournit une interface de UserRoleRepository pour le pattern UnitOfWork
    /// </summary>
    public interface IUserRoleRepository : IGenericRepository<BO.UserRole>
    {
        bool Exists(int userId, string roleName);
    }
}
