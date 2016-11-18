using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Data.Entity;
using EntityFramework.Extensions;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Représente l'entrepot de données de l'entité T.
    /// </summary>
    public class ParticipantRepository :  GenericRepository<BO.Participation>, IParticipantRepository
    {
        private readonly EFDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de la classe EntityRepository à l'aide d'un contexte.
        /// </summary>
        /// <param name="context"></param>
        public ParticipantRepository(EFDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
