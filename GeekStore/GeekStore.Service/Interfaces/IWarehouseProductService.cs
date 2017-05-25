using GeekStore.Service.DTO;

namespace GeekStore.Service.Interfaces
{
    public interface IWarehouseProductService
    {
        WarehouseProductDTO GetByProductId(int productId);
    }
}