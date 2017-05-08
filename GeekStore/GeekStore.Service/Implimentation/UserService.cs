using System;
using AutoMapper;
using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;

namespace GeekStore.Service.Implimentation
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public void Create(UserDTO user)
        {
            _userRepository.CreateUser(_mapper.Map<UserDTO, User>(user));
        }
    }
}
