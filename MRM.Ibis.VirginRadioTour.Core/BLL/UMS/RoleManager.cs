using NLog;
using System.Collections.Generic;

namespace MRM.UMS.Core.BLL
{
    public class RoleManager
    {
        private static Logger log = NLog.LogManager.GetLogger("RoleManager");

        private readonly DAL.IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initialise une nouvelle instance de la classe RoleManager.
        /// </summary>
        public RoleManager()
            : this(new Core.DAL.UnitOfWork(new Core.DAL.EFDbContext()))
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe RoleManager à l'aide d'un UnitOfWork.
        /// </summary>
        /// <param name="context"></param>
        public RoleManager(DAL.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Obtient la liste de tous les rôles.
        /// </summary>
        /// <returns>Liste de l'ensemble des rôles stockés dans la source de données.</returns>
        public List<BO.Role> GetAll()
        {
            return _unitOfWork.RoleRepository.FindAll(r => true);
        }

        /// <summary>
        /// Obtient la liste des rôles dans lesquels figure l'utilisateur spécifié.
        /// </summary>
        /// <param name="userId">Identifiant utilisateur pour lequel retourner une liste de rôles.</param>
        /// <returns>Liste des rôles dans lesquels figure l'utilisateur spécifié.</returns>
        public List<BO.Role> GetRolesForUser(int userId)
        {
            return _unitOfWork.RoleRepository.GetForUser(userId);
        }
    }
}
