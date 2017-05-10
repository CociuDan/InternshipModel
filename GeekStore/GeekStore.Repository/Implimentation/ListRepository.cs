using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain;
using GeekStore.Domain.Model;

namespace GeekStore.Repository.Implimentation
{
    public class ListRepository<T>// : IRepository
    {
        public void Delete<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByManufacturer(string manufacturer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByModel(string model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetCPUs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Laptop> GetLaptops()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CPU> GetTOPCPUs()
        {
            throw new NotImplementedException();
        }

        public void Save(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
