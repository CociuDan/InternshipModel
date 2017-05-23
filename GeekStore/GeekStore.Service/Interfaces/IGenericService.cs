using GeekStore.Service.DTO;
using System;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGenericService<TDTO> where TDTO : EntityDTO
    {
        IEnumerable<TDTO> GetAll();
        IEnumerable<TDTO> GetAllPaged(int page, int pageSize);
        //IEnumerable<TDTO> GetAllAvailablePaged(int page, int pageSize, Func<TDTO, bool> criteria);
        TDTO GetById(int id);
        int Save(TDTO entity);
        void Update(TDTO entity);
        void Delete(int entityId);

    }
}