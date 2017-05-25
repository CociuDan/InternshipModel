using GeekStore.Domain.Model;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetAll(int UserId);
    }
}