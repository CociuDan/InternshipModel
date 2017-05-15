using GeekStore.Service.DTO;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGenericService<TDTOs> where TDTOs : EntityDTO
    {
        IEnumerable<TDTOs> GetAll();
        IEnumerable<TDTOs> GetAllPaged(int page, int pageSize);
        TDTOs GetById(int id);
        void Save(TDTOs entity);
        void Update(TDTOs entity);
        void Delete(TDTOs entity);
    }
}