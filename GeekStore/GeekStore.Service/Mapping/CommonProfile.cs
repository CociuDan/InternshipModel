using AutoMapper;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Mapping
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            CreateMap<ICase, Case>().ReverseMap();
            CreateMap<ICooler, Cooler>().ReverseMap();
            CreateMap<ICPU, CPU>().ReverseMap();
            CreateMap<IDisk, Disk>();
            CreateMap<IDisplay, Display>();
            CreateMap<IEntity, IEntity>().ReverseMap();
            CreateMap<IGPU, GPU>().ReverseMap();
            CreateMap<IHeadphones, Headphones>().ReverseMap();
            CreateMap<IKeyboard, Keyboard>().ReverseMap();
            CreateMap<ILaptop, Laptop>().ReverseMap();
            CreateMap<IMonitor, Monitor>().ReverseMap();
            CreateMap<IMotherboard, Motherboard>().ReverseMap();
            CreateMap<IMouse, Mouse>().ReverseMap();
            CreateMap<IPowerUnit, PowerUnit>().ReverseMap();
            CreateMap<IProduct, Product>().ReverseMap();
            CreateMap<IRAM, RAM>().ReverseMap();
            CreateMap<ISpeakers, Speakers>().ReverseMap();
        }
    }
}
