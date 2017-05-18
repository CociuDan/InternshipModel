using GeekStore.Domain;
using System;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllPaged(int page, int pageSize);
        T GetById(int id);
        void Save(T entity);
        void Update(T entity);
        void Delete(int entityId);
    }
}