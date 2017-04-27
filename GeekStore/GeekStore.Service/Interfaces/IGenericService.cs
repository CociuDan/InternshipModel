using GeekStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces
{
    public interface IGenericService<TViewModel> where TViewModel : IEntity
    {
        IEnumerable<TViewModel> GetAll();
        IEnumerable<TViewModel> GetAllPaged(int page, int pageSize);
        TViewModel GetById(int id);
        void Save(TViewModel entity);
        void Update(TViewModel entity);
        void Delete(TViewModel entity);
    }
}
