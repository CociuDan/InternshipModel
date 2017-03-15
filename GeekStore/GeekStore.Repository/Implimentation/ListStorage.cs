using System.Collections.Generic;
using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;
using GeekStore.Model.Components.CPUs;

namespace GeekStore.Repository.Implimentation
{
    public class ListStorage<T> : IStorage<T> where T : Product
    {
        List<T> _items = new List<T>();

        public void DeleteItemByID(int itemID)
        {
            _items.Remove(_items.Where(x => x.ID == itemID).First());
        }

        public IEnumerable<T> GetItems()
        {
            return _items;
        }

        public IEnumerable<T> GetItemsByCriteria(Func<T, bool> criteria)
        {
            return _items.Where(criteria);
        }

        public void SaveItem(T item)
        {
            _items.Add(item);
        }
    }
}
