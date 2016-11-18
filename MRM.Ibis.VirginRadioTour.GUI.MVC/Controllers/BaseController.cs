using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NLog;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers
{
    /// <summary>
    /// Fournit des méthodes qui répondent aux requêtes HTTP envoyées à un site Web ASP.NET MVC.
    /// </summary>
    public abstract partial class BaseController : Controller
    {
        
    }

    /// <summary>
    /// Initialisation automatique d'un gestionnaire de logs.
    /// </summary>
    public abstract partial class BaseController : Controller
    {
        private Logger _log;
        protected virtual Logger Log { get { return (_log = _log ?? LogManager.GetCurrentClassLogger()); } }
    }

    /// <summary>
    /// Initialisation automatique d'une unité de travail.
    /// </summary>
    public abstract partial class BaseController : Controller
    {
        public Core.DAL.IUnitOfWork UnitOfWork { get; protected set; }

        public BaseController()
            : this(new Core.DAL.UnitOfWork(new Core.DAL.EFDbContext()))
        {
        }

        public BaseController(Core.DAL.IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = RegisterDisposable(unitOfWork);
        }
    }


    /// <summary>
    /// Gestion de la disposabilité conjointe au controller. 
    /// </summary>
    public abstract partial class BaseController : Controller
    {
        private IList<IDisposable> _disposables = null;

        protected T RegisterDisposable<T>(T disposable) where T : IDisposable
        {
            if (disposable != null)
            {
                _disposables = _disposables ?? new List<IDisposable>();
                if (!_disposables.Contains(disposable))
                    _disposables.Add(disposable);
            }
            return disposable;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_disposables != null)
                    foreach (IDisposable disposable in _disposables)
                        if (disposable != null)
                            disposable.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}