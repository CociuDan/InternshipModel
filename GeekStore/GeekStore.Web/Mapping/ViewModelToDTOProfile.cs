using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekStore.UI.Mapping
{
    public class ViewModelToDTOProfile : Profile
    {
        public ViewModelToDTOProfile()
        {
            //Mapping View Models to DTOs
            CreateMap<CaseViewModel, CaseDTO>().ReverseMap();
            CreateMap<CoolerViewModel, CoolerDTO>().ReverseMap();
            CreateMap<CPUViewModel, CPUDTO>().ReverseMap();
            CreateMap<DiskViewModel, DiskDTO>().ReverseMap();
            CreateMap<DisplayViewModel, DisplayDTO>().ReverseMap();
            CreateMap<EntityViewModel, EntityDTO>().ReverseMap();
            CreateMap<GPUViewModel, GPUDTO>().ReverseMap();
            CreateMap<HeadphonesViewModel, HeadphonesDTO>().ReverseMap();
            CreateMap<KeyboardViewModel, KeyboardDTO>().ReverseMap();
            CreateMap<LaptopViewModel, LaptopDTO>().ReverseMap();
            CreateMap<MonitorViewModel, MonitorDTO>().ReverseMap();
            CreateMap<MotherboardViewModel, MotherboardDTO>().ReverseMap();
            CreateMap<MouseViewModel, MouseDTO>().ReverseMap();
            CreateMap<PowerUnitViewModel, PowerUnitDTO>().ReverseMap();
            CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
            CreateMap<RAMViewModel, RAMDTO>().ReverseMap();
            CreateMap<SpeakersViewModel, SpeakersDTO>().ReverseMap();
        }
    }
}