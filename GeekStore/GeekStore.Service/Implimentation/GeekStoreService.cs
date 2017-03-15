using GeekStore.Model;
using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.Interfaces;
using GeekStore.Repository.Implimentation;
using System;

namespace GeekStore.Service.Implimentation
{
    public class GeekStoreService<T> : IGeekStoreService<T> where T : Product
    {
        IStorage<T> _storage = new ListStorage<T>();

        public void DeleteItemByID(int itemID)
        {
            _storage.DeleteItemByID(itemID);
        }

        public IEnumerable<T> GetItems()
        {
            return _storage.GetItems();
        }

        public IEnumerable<T> GetItemByCriteria(Func<T, bool> criteria)
        {
            return _storage.GetItemsByCriteria(criteria);
        }

        public void SaveItem(T item)
        {
            _storage.SaveItem(item);
        }
    }
}
