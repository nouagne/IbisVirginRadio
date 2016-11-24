using NLog;
using System;

namespace MRM.UMS.Core.BLL
{
    public class UserManager
    {
        private static Logger log = NLog.LogManager.GetLogger("UserManager");

        private readonly DAL.IUnitOfWork _unitOfWork;

        // <summary>
        /// Initialise une nouvelle instance de la classe UserManager.
        /// </summary>
        public UserManager()
            : this(new DAL.UnitOfWork(new DAL.EFDbContext()))
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe UserManager à l'aide d'un UnitOfWork.
        /// </summary>
        /// <param name="context"></param>
        public UserManager(DAL.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Authentifie un utilisateur à partir de son email et de son mot de passe
        /// </summary>
        /// <param name="email">email de l'utilisateur</param>
        /// <param name="password">mot de passe de l'utilisateur</param>
        /// <returns></returns>
        public BO.User Authenticate(string email, string password)
        {
            BO.User user = _unitOfWork.UserRepository.Find(a => a.Email.Equals(email));
            if (user == null)
            {
                throw new Exceptions.UserNotFoundException();
            }
            if (user.Password != password)
            {
                throw new Exceptions.WrongPasswordException();
            }
            return user;
        }

        /// <summary>
        /// Détermine si un utilisateur existe à partir d'identifiants.
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur à vérifier.</param>
        /// <param name="uuid">UUID de l'utilisateur à vérifier.</param>
        /// <returns>true si un utilisateur existe avec ces identifiants; sinon, false.</returns>
        public bool Exists(int id, Guid uuid)
        {
            BO.User user = _unitOfWork.UserRepository.Find(u => u.Id == id);
            if (user == null || user.UUID != uuid)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtient une valeur indiquant si l'utilisateur indiqué figure dans le rôle spécifié.
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur à rechercher.</param>
        /// <param name="roleName">Rôle dans lequel effectuer la recherche.</param>
        /// <returns>true si l'utilisateur spécifié figure dans le rôle spécifié; sinon, false.</returns>
        public bool IsUserInRole(int userId, string roleName)
        {
            return _unitOfWork.UserRoleRepository.Exists(userId, roleName);
        }
    }
}
