using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Repository.Implimentation
{
    public class FileStorage<T> : IStorage<T> where T : Product
    {
        public void DeleteItemByID(int itemID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItemsByCriteria(Func<T, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public void SaveItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
