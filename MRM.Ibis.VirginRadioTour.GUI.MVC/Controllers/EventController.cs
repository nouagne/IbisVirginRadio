using AutoMapper;
using MRM.Ibis.VirginRadioTour.Core.BLL;
using MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels;
using System;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers
{
    public class EventController : BaseController
    {
        // GET: Event
        public ActionResult EventDetails(string eventId)
        {
            try
            {
                EventManager manager = new EventManager(UnitOfWork);
                var @event = manager.FindByName(eventId);

                return PartialView("_EventDetails",Mapper.Map<EventViewModel>(@event));
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}