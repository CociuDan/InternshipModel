using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain;
using GeekStore.Domain.Model;

namespace GeekStore.Repository.Implimentation
{
    public class ListRepository<T> : IRepository
    {
        public void Delete<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : Item
        {
            throw new NotImplementedException();
        }

        public Item GetById<T1>(int id) where T1 : Item
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> GetByManufacturer<T1>(string manufacturer) where T1 : Product
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> GetByModel<T1>(string model) where T1 : Product
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetCPUs<T>()
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

        public void Save<T1>(T1 item) where T1 : Item
        {
            throw new NotImplementedException();
        }

        public void Update<T1>(T1 item)
        {
            throw new NotImplementedException();
        }
    }
}
