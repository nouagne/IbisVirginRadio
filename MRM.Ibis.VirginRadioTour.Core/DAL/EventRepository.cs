using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    public class EventRepository : GenericRepository<BO.Event>, IEventRepository
    {
        private readonly EFDbContext _context;

        public EventRepository(EFDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
