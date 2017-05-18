using GeekStore.Domain.Model;
using GeekStore.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces
{
    public interface IProductService<TDTOModel> where TDTOModel : ProductDTO
    {
        IEnumerable<TDTOModel> GetByManufacturer(string manufacturer);
        IEnumerable<TDTOModel> GetByModel(string model);
        IEnumerable<TDTOModel> GetAllAvailablePaged(int page, int pageSize, Expression<Func<TDTOModel, bool>> criteria);
    }
}
