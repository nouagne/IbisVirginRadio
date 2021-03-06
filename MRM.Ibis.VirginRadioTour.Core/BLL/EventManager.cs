﻿using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM.Ibis.VirginRadioTour.Core.BLL
{
    public class EventManager
    {
        private readonly DAL.IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initialise une nouvelle instance de la classe EventManager.
        /// </summary>
        public EventManager()
            : this(new Core.DAL.UnitOfWork(new Core.DAL.EFDbContext()))
        {

        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe EventManager à l'aide d'un UnitOfWork.
        /// </summary>
        /// <param name="context"></param>
        public EventManager(DAL.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Event FindByName(string name)
        {
            var @event = _unitOfWork.EventRepository.Find(e => e.City == name);

            if (@event == null)
                throw new EventNotFoundException();

            return @event;
        }

        public Event FindById(int id)
        {
            var @event = _unitOfWork.EventRepository.Find(e => e.Id == id);

            if (@event == null)
                throw new EventNotFoundException();

            return @event;
        }

    }
}
