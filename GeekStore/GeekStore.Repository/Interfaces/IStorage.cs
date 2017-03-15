using GeekStore.Model;
using System;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IStorage<T>
    {
        void DeleteItemByID(int itemID);
        IEnumerable<T> GetItems();
        IEnumerable<T> GetItemsByCriteria(Func<T, bool> criteria);
        void SaveItem(T item);


    }
}
