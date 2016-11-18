using AutoMapper;
using MRM.Ibis.VirginRadioTour.Core.BO;
using MRM.Ibis.VirginRadioTour.GUI.MVC.ViewModels;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ValidationViewModel, Participation>();
                config.CreateMap<Participation, ValidationViewModel>();
                config.CreateMap<Participation, ParticipationViewModel>();
                config.CreateMap<ParticipationViewModel, Participation>();
            });
        }
    }
}