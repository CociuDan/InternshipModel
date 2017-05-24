using GeekStore.Domain;
using GeekStore.Infrastucture.Extensions;
using System;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllPaged(PagedRequestDescription pageDescription);
        T GetById(int id);
        int Save(T entity);
        void Update(T entity);
        void Delete(int entityId);
        int GetAllCount();
    }
}