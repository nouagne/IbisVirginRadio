namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Manage Users within a db context
    /// </summary>
    public class UserRepository : GenericRepository<BO.User>, IUserRepository
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe UserRepository à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(EFDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
