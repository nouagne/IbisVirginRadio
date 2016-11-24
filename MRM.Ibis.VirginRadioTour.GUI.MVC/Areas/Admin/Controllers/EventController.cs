using AutoMapper;
using MRM.Ibis.VirginRadioTour.Core.BLL;
using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers;
using MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.Controllers
{
    public class EventController : BaseController
    {
        // GET: Admin/EventController
        public ActionResult Index()
        {
            var manager = new EventManager(UnitOfWork);
            var events = manager.FindAll();

            return View(events);
        }

        public ActionResult Create()
        {
            var model = new EventViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EventViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var manager = new EventManager(UnitOfWork);
                    manager.Create(Mapper.Map<Event>(vm));

                    return RedirectToAction("Index");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                }
            }
            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            var manager = new EventManager(UnitOfWork);
            var @event = manager.FindById(id);
            return View(Mapper.Map<EventViewModel>(@event));
        }

        [HttpPost]
        public ActionResult Edit(EventViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var manager = new EventManager(UnitOfWork);
                    manager.Update(vm.Id.Value, vm.City, vm.InscriptionsStartDate, vm.InscriptionsEndDate, vm.StartDate, vm.EndDate);
                    return View();
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                }
            }
            return View(vm);
        }
    }
}