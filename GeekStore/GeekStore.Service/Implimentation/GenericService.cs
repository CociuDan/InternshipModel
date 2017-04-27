using System;
using System.Collections.Generic;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Models;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;
using AutoMapper;

namespace GeekStore.Service.Implimentation
{
    public class GenericService<TViewModel, TDomainModel> : IGenericService<TViewModel> where TViewModel : IEntity where TDomainModel : Entity
    {
        private readonly IGenericRepository<TDomainModel> _genericRepository = null;
        private readonly IMapper _mapper = null;

        public GenericService(IMapper mapper, IGenericRepository<TDomainModel> genericRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public void Delete(TViewModel entity)
        {
            var domainEntity = _mapper.Map<TViewModel, TDomainModel>(entity);
            _genericRepository.Delete(domainEntity);
        }

        public IEnumerable<TViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TViewModel>>(_genericRepository.GetAll());
        }

        public IEnumerable<TViewModel> GetAllPaged(int page, int pageSize)
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TViewModel>>(_genericRepository.GetAllPaged(page, pageSize));
        }

        public TViewModel GetById(int id)
        {
            return _mapper.Map<TDomainModel, TViewModel>(_genericRepository.GetById(id));
        }

        public void Save(TViewModel entity)
        {
            var domainEntity = _mapper.Map<TViewModel, TDomainModel>(entity);
            _genericRepository.Save(domainEntity);
        }

        public void Update(TViewModel entity)
        {
            var domainEntity = _mapper.Map<TViewModel, TDomainModel>(entity);
            _genericRepository.Update(domainEntity);
        }
    }
}
