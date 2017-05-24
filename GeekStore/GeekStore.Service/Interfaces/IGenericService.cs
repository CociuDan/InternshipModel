using GeekStore.Infrastucture.Extensions;
using GeekStore.Service.DTO;
using System;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface IGenericService<TDTO> where TDTO : EntityDTO
    {
        IEnumerable<TDTO> GetAll();
        IEnumerable<TDTO> GetAllPaged(PagedRequestDescription pageDescription);
        TDTO GetById(int id);
        int Save(TDTO entity);
        void Update(TDTO entity);
        void Delete(int entityId);
        int GetAllCount();
    }
}