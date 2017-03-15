using System;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGeekStoreService<T>
    {
        void DeleteItemByID(int itemID);
        IEnumerable<T> GetItems();
        IEnumerable<T> GetItemByCriteria(Func<T, bool> criteria);
        void SaveItem(T item);
    }
}
