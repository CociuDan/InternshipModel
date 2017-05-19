using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.UI.Models;

namespace GeekStore.UI.Mapping
{
    public class ViewModelToDTOProfile : Profile
    {
        public ViewModelToDTOProfile()
        {
            //Mapping View Models to DTOs
            CreateMap<CartViewModel, CartDTO>().ReverseMap();
            CreateMap<CaseViewModel, CaseDTO>();
            CreateMap<CaseDTO, CaseViewModel>().ForMember(x => x.Description, o=>o.Ignore()).ForMember(y=>y.Quantity, o=>o.Ignore());
            CreateMap<CoolerViewModel, CoolerDTO>().ReverseMap();
            CreateMap<CPUViewModel, CPUDTO>().ReverseMap();
            CreateMap<DiskViewModel, DiskDTO>().ReverseMap();
            CreateMap<DisplayViewModel, DisplayDTO>().ReverseMap();
            CreateMap<EntityViewModel, EntityDTO>().ForMember(dest=>dest.ID, opt=>opt.Ignore());
            CreateMap<EntityDTO, EntityViewModel>();
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
            CreateMap<UserViewModel, UserDTO>().ReverseMap();
        }
    }
}