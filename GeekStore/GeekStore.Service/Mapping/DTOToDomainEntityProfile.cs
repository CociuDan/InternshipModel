using AutoMapper;
using GeekStore.Domain;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;
using GeekStore.Service.DTO;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace GeekStore.Service.Mapping
{
    public class DTOToDomainEntityProfile : Profile
    {
        public DTOToDomainEntityProfile()
        {
            CreateMap<CaseDTO, Case>().ReverseMap();
            CreateMap<CoolerDTO, Cooler>().ReverseMap();
            CreateMap<CPUDTO, CPU>().ReverseMap();
            CreateMap<DiskDTO, Disk>();
            CreateMap<DisplayDTO, Display>();
            CreateMap<EntityDTO, Entity>().ReverseMap();
            CreateMap<GPUDTO, GPU>().ReverseMap();
            CreateMap<HeadphonesDTO, Headphones>().ReverseMap();
            CreateMap<KeyboardDTO, Keyboard>().ReverseMap();
            CreateMap<LaptopDTO, Laptop>().ReverseMap();
            CreateMap<MonitorDTO, Monitor>().ReverseMap();
            CreateMap<MotherboardDTO, Motherboard>().ReverseMap();
            CreateMap<MouseDTO, Mouse>().ReverseMap();
            CreateMap<PowerUnitDTO, PowerUnit>().ReverseMap();
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<RAMDTO, RAM>().ReverseMap();
            CreateMap<SpeakersDTO, Speakers>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<WarehouseProductDTO, WarehouseProduct>().ReverseMap();
            CreateMap<Task<UserDTO>, Task<User>>().ReverseMap();
            CreateMap<Func<UserDTO, bool>, Func<User, bool>>().ReverseMap();
            CreateMap<Func<CaseDTO, bool>, Func<Case, bool>>().ReverseMap();
            CreateMap<Func<ProductDTO, bool>, Func<Product, bool>>().ReverseMap();
            CreateMap<Func<EntityDTO, bool>, Func<Entity, bool>>().ReverseMap();

            CreateMap<Expression<Func<CaseDTO, bool>>, Expression<Func<Case, bool>>>();
            CreateMap<Expression<Func<ProductDTO, bool>>, Expression<Func<Product, bool>>>();
            CreateMap<Expression<Func<EntityDTO, bool>>, Expression<Func<Entity, bool>>>();


        }
    }
}