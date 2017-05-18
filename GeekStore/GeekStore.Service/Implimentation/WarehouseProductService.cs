using GeekStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekStore.Service.DTO;
using GeekStore.Repository.Interfaces;
using AutoMapper;
using NHibernate;
using GeekStore.Domain.Model;

namespace GeekStore.Service.Implimentation
{
    public class WarehouseProductService : IWarehouseProductService
    {
        private readonly IWarehouseProductRepository _warehouseProductRepository = null;
        private readonly IMapper _mapper = null;
        private readonly ITransaction _transaction = null;

        public WarehouseProductService(IWarehouseProductRepository warehouseProductRepository, IMapper mapper, ITransaction transaction)
        {
            _warehouseProductRepository = warehouseProductRepository;
            _mapper = mapper;
            _transaction = transaction;
        }

        public WarehouseProductDTO GetByProductId(int productId)
        {
            return _mapper.Map<WarehouseProduct, WarehouseProductDTO>(_warehouseProductRepository.GetByProductId(productId));
        }
    }
}
