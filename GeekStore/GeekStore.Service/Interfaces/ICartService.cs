using GeekStore.Service.DTO;
using System.Collections.Generic;

namespace GeekStore.Service.Interfaces
{
    public interface ICartService
    {
        IEnumerable<CartDTO> GetAll(int UserId);
    }
}