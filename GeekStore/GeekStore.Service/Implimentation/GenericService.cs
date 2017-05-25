using System.Collections.Generic;
using GeekStore.Service.Interfaces;
using GeekStore.Service.DTO;
using GeekStore.Repository.Interfaces;
using AutoMapper;
using NHibernate;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Domain.Model;

namespace GeekStore.Service.Implimentation
{
    public class GenericService<TDTOModel, TDomainModel> : IGenericService<TDTOModel> where TDTOModel : EntityDTO where TDomainModel : Entity
    {
        private readonly IGenericRepository<TDomainModel> _genericRepository = null;
        private readonly IMapper _mapper = null;
        private readonly ITransaction _transaction = null;

        public GenericService(IGenericRepository<TDomainModel> genericRepository, IMapper mapper, ITransaction transaction)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _transaction = transaction;
        }
        public void Delete(int entityId)
        {
            _genericRepository.Delete(entityId);
            _transaction.Commit();
        }

        public IEnumerable<TDTOModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TDTOModel>>(_genericRepository.GetAll());
        }

        public int GetAllCount()
        {
            return _genericRepository.GetAllCount();
        }

        public IEnumerable<TDTOModel> GetAllPaged(PagedRequestDescription pageDescription)
        {
            return _mapper.Map<IEnumerable<TDomainModel>, IEnumerable<TDTOModel>>(_genericRepository.GetAllPaged(pageDescription));
        }

        public TDTOModel GetById(int id)
        {
            return _mapper.Map<TDomainModel, TDTOModel>(_genericRepository.GetById(id));
        }

        public int Save(TDTOModel entity)
        {
            var id = _genericRepository.Save(_mapper.Map<TDTOModel, TDomainModel>(entity));
            _transaction.Commit();
            return id;
        }

        public void Update(TDTOModel entity)
        {
            _genericRepository.Update(_mapper.Map<TDTOModel, TDomainModel>(entity));
            _transaction.Commit();
        }
    }
}