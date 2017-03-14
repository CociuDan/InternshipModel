using GeekStore.Model;
using System.Collections.Generic;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.Interfaces;
using GeekStore.Repository.Implimentation;
using System;

namespace GeekStore.Service.Implimentation
{
    public class GeekStoreService : IGeekStoreService<IItem>
    {
        private IStorage<IItem> _storage = new ListStorage();

        public void DeleteItemByID(int itemID)
        {
            _storage.DeleteItemByID(itemID);
        }

        public IEnumerable<IItem> GetCompatibleItems<T>(string socket)
        {
            return _storage.GetCompatibleItems<T>(socket);
        }

        public IItem GetItemByID(int itemID)
        {
            return _storage.GetItemByID(itemID);
        }

        public IEnumerable<IItem> GetItems()
        {
            return _storage.GetItems();
        }

        public IEnumerable<IItem> GetItemsByPrice<T>(double minPrice, double maxPrice)
        {
            return _storage.GetItemsByPrice<T>(minPrice, maxPrice);
        }

        public IEnumerable<IItem> GetItemsByType<T>()
        {
            return _storage.GetItemsByType<T>();
        }

        public void SaveItem(IItem item)
        {
            _storage.SaveItem(item);
        }

        public IEnumerable<IItem> GetItemByCriteria(Func<IItem, bool> criteria)
        {
            return _storage.GetItemsByCriteria(criteria);
        }
    }
}
