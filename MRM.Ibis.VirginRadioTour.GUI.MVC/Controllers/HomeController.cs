using AutoMapper;
using MRM.Ibis.VirginRadioTour.Core.BLL;
using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.Core.Exceptions;
using MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels;
using System;
using System.Net;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string eventId)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult Participate(string eventId, ViewModels.ParticipationViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ParticipationManager manager = new ParticipationManager(UnitOfWork);
                    Participation participation = Mapper.Map<Participation>(vm);

                    manager.Participate(participation);

                    return RedirectToAction("Confirm", new { participationId = participation.Id, participationUID = participation.UID });
                }
                catch(EmailAlreadyExistsException)
                {
                    ModelState.AddModelError("Email", "Cet email a déjà été utilisé");
                }
                catch(Exception)
                {
                    ModelState.AddModelError("Error", "Une erreur est survenue lors de votre participation");
                }
            }
            return View(vm);
        }

        public ActionResult Confirm(string eventId, int participationId, Guid participationUID)
        {
            try
            {
                ParticipationManager manager = new ParticipationManager(UnitOfWork);
                Participation participation = manager.Find(eventId, participationId, participationUID);

                return View(Mapper.Map(participation, new ParticipationViewModel()));
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
        }

        public ActionResult Validate(string eventId, int id, Guid uid)
        {
            try
            {
                ParticipationManager manager = new ParticipationManager(UnitOfWork);
                Participation participation = manager.Find(eventId, id, uid);

                if (!participation.IsWinner)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }
                
                return View(Mapper.Map(participation, new ValidationViewModel()));
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        [ActionName("Validate")]
        [ValidateAntiForgeryToken]
        public ActionResult ValidateParticipation(string eventId, ValidationViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    ParticipationManager manager = new ParticipationManager(UnitOfWork);

                    var participation = Mapper.Map(vm,new Participation());
                    
                    manager.Validate(eventId, participation);

                    return RedirectToAction("Invite", new { participationId = participation.Id, participationUID = participation.UID });

                }
                catch
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }
            }
            return View(vm);
        }

        public ActionResult Invite(string eventId, int participationId, Guid participationUID)
        {
            try
            {
                ParticipationManager manager = new ParticipationManager(UnitOfWork);
                Participation participation = manager.Find(eventId, participationId, participationUID);

                if (!participation.ValidationDate.HasValue)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }

                return View(Mapper.Map(participation, new ValidationViewModel()));
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
        }

        public ActionResult End()
        {
            return View();
        }

        public ActionResult NoEvent()
        {
            return View();
        }
    }
}