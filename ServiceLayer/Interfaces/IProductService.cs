using ServiceLayer.DTOs;
using System.Collections.Generic;

namespace ServiceLayer.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();
    }
}