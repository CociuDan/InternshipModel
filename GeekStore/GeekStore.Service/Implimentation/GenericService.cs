using System;
using System.Collections.Generic;
using GeekStore.Service.Interfaces;
using GeekStore.Service.DTO;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;
using AutoMapper;

namespace GeekStore.Service.Implimentation
{
    public class GenericService<TDTOModel, TDomainModel> : IGenericService<TDTOModel> where TDTOModel : EntityDTO where TDomainModel : Entity
    {
        private readonly IGenericRepository<TDomainModel> _genericRepository = null;
        private readonly IMapper _mapper = null;

        public GenericService(IGenericRepository<TDomainModel> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public void Delete(TDTOModel entity)
        {
            var domainEntity = _mapper.Map<TDTOModel, TDomainModel>(entity);
            _genericRepository.Delete(domainEntity);
        }

        public IEnumerable<TDTOModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TDTOModel>>(_genericRepository.GetAll());
        }

        public IEnumerable<TDTOModel> GetAllPaged(int page, int pageSize)
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TDTOModel>>(_genericRepository.GetAllPaged(page, pageSize));
        }

        public TDTOModel GetById(int id)
        {
            return _mapper.Map<TDomainModel, TDTOModel>(_genericRepository.GetById(id));
        }

        public void Save(TDTOModel entity)
        {
            var domainEntity = _mapper.Map<TDTOModel, TDomainModel>(entity);
            _genericRepository.Save(domainEntity);
        }

        public void Update(TDTOModel entity)
        {
            var domainEntity = _mapper.Map<TDTOModel, TDomainModel>(entity);
            _genericRepository.Update(domainEntity);
        }
    }
}