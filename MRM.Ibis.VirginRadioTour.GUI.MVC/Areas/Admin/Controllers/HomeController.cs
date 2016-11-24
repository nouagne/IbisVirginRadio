using MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.ViewModels;
using MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes;
using MRM.UMS.Core.BLL;
using MRM.UMS.Core.BO;
using MRM.UMS.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.Controllers
{
    [AuthorizeIPAddress]
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        [ActionName("LogIn")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Authenticate(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var unitOfWork = new UnitOfWork(new EFDbContext()))
                    {
                        var userManager = new UserManager(unitOfWork);
                        User user = userManager.Authenticate(model.Email, model.Password);
                        FormsAuthentication.SetAuthCookie("admin::" + user.Id.ToString(), false);
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(model);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("LogIn");
        }
    }
}