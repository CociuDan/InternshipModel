using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain.Model;

namespace GeekStore.Service.Implimentation
{
    public class ProductService<TDTOModel, TDomainModel> : IProductService<TDTOModel> where TDTOModel : ProductDTO where TDomainModel : Product
    {
        private IProductRepository<TDomainModel> _productRepository;
        private IMapper _mapper;
        private ITransaction _transaction;

        public ProductService(IProductRepository<TDomainModel> productRepository, IMapper mapper, ITransaction transaction)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _transaction = transaction;
        }

        public IEnumerable<TDTOModel> GetAllAvailablePaged(int page, int pageSize, Expression<Func<TDTOModel, bool>> criteria)
        {

            var a = _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TDTOModel>>
                (
                    _productRepository.GetAllAvailablePaged
                        (
                            page, pageSize, _mapper.Map<Expression<Func<TDTOModel, bool>>, Expression<Func<TDomainModel, bool>>>(criteria)
                        )
                );
            return a;
        }

        public IEnumerable<TDTOModel> GetByManufacturer(string manufacturer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TDTOModel> GetByModel(string model)
        {
            throw new NotImplementedException();
        }
    }
}