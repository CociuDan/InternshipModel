using GeekStore.Model;
using System;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IStorage<IItem>
    {
        IEnumerable<IItem> GetItems();

        IItem GetItemByID(int itemID);

        void DeleteItemByID(int itemID);

        void SaveItem(IItem item);

        IEnumerable<IItem> GetItemsByPrice<T>(double minPrice, double maxPrice);

        IEnumerable<IItem> GetCompatibleItems<T>(string socket);

        IEnumerable<IItem> GetItemsByType<T>();

        IEnumerable<IItem> GetItemsByCriteria(Func<IItem, bool> criteria);
    }
}
