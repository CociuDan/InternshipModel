using System.Collections.Generic;
using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System.Linq;
using System;
using GeekStore.Model.Components.CPUs;

namespace GeekStore.Repository.Implimentation
{
    public class ListStorage : IStorage<IItem>
    {
        private List<IItem> _warehouseItems = new List<IItem>();

        public void SaveItem(IItem item)
        {
            _warehouseItems.Add(item);
        }

        public void DeleteItemByID(int itemID)
        {
            _warehouseItems.Remove(_warehouseItems.Where(x => x.ID == itemID).First());
        }

        public IItem GetItemByID(int itemID)
        {
            return _warehouseItems.Find(x => x.ID == itemID);
        }

        public IEnumerable<IItem> GetItems()
        {
            return _warehouseItems;
        }

        public IEnumerable<IItem> GetItemsByPrice<T>(double minPrice, double maxPrice)
        {
            return _warehouseItems.Where(x => x is T && x.Price >= minPrice && x.Price <= maxPrice);
        }

        public IEnumerable<IItem> GetCompatibleItems<T>(string socket)
        {
            return _warehouseItems.Where(x => x is T && x.Description.Contains(socket));
        }

        public IEnumerable<IItem> GetItemsByType<T>()
        {
            return _warehouseItems.Where(x => x is T);
        }

        public IEnumerable<IItem> GetItemsByCriteria<T>(Func<IItem, bool> criteria)
        {
            return _warehouseItems.Where(x => x is T).Where(criteria);
        }
    }
}
