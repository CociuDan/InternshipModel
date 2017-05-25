using GeekStore.Service.Interfaces;
using System.Collections.Generic;
using GeekStore.Service.DTO;
using AutoMapper;
using GeekStore.Repository.Interfaces;
using NHibernate;
using GeekStore.Domain.Model;

namespace GeekStore.Service.Implimentation
{
    public class CartService : ICartService
    {
        private ICartRepository _cartRepository;
        private IMapper _mapper;
        private ITransaction _transaction;

        public CartService(ICartRepository cartRepository, IMapper mapper, ITransaction transaction)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
            _transaction = transaction;
        }
        public IEnumerable<CartDTO> GetAll(int UserId)
        {
            return _mapper.Map<IEnumerable<Cart>, IEnumerable<CartDTO>>(_cartRepository.GetAll(UserId));
        }
    }
}