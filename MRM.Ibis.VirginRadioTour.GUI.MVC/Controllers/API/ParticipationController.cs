using MRM.Ibis.VirginRadioTour.Core.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers.API
{
    public class ParticipationController : BaseController
    {
        [HttpPost]
        public HttpResponseMessage DeclareWinner(string eventId, int id, Guid uid)
        {
            try
            {
                var manager = new ParticipationManager(UnitOfWork);
                manager.DeclareWinner(eventId, id, uid);

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }
    }
}
