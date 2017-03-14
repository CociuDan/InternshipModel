using System;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGeekStoreService<IItem>
    {
        IEnumerable<IItem> GetItems();

        IItem GetItemByID(int itemID);

        void DeleteItemByID(int itemID);

        void SaveItem(IItem item);

        IEnumerable<IItem> GetItemsByPrice<T>(double minPrice, double maxPrice);

        IEnumerable<IItem> GetCompatibleItems<T>(string socket);

        IEnumerable<IItem> GetItemsByType<T>();

        IEnumerable<IItem> GetItemByCriteria(Func<IItem, bool> criteria);
    }
}
