using GeekStore.Domain.Model.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces.Components
{
    public interface ICaseService
    {
        IEnumerable<Case> GetAll();
        IEnumerable<Case> GetAllPaged(int page, int pageSize);
        Case GetById(int id);
        void Save(Case entity);
        void Update(Case entity);
        void Delete(Case entity);
    }
}
