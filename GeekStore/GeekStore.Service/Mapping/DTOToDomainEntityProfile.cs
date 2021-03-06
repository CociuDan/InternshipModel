﻿using AutoMapper;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Domain.Model.PCs;
using GeekStore.Service.DTO;

namespace GeekStore.Service.Mapping
{
    public class DTOToDomainEntityProfile : Profile
    {
        public DTOToDomainEntityProfile()
        {
            CreateMap<CaseDTO, Case>().ReverseMap();
            CreateMap<CoolerDTO, Cooler>().ReverseMap();
            CreateMap<CPUDTO, CPU>().ReverseMap();
            CreateMap<DesktopDTO, Desktop>().ReverseMap();
            CreateMap<DiskDTO, Disk>().ReverseMap();
            CreateMap<DisplayDTO, Display>().ReverseMap();
            CreateMap<EntityDTO, Entity>().ReverseMap();
            CreateMap<GPUDTO, GPU>().ReverseMap();
            CreateMap<HeadphonesDTO, Headphones>().ReverseMap();
            CreateMap<KeyboardDTO, Keyboard>().ReverseMap();
            CreateMap<LaptopDTO, Laptop>().ReverseMap();
            CreateMap<MonitorDTO, Monitor>().ReverseMap();
            CreateMap<MotherboardDTO, Motherboard>().ReverseMap();
            CreateMap<MouseDTO, Mouse>().ReverseMap();
            CreateMap<PowerUnitDTO, PowerUnit>().ReverseMap();
            CreateMap<ProductDTO, Product>()
                .Include<CaseDTO, Case>();
            CreateMap<Product, ProductDTO>()
                .Include<Case, CaseDTO>();
            CreateMap<RAMDTO, RAM>().ReverseMap();
            CreateMap<SpeakersDTO, Speakers>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
        }
    }
}