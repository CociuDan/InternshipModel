using GeekStore.Domain.Model;

namespace GeekStore.Repository.Interfaces
{
    public interface IWarehouseProductRepository
    {
        WarehouseProduct GetByProductId(int productId);
    }
}