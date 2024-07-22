using ServiceLayer.DTOs;
using System.Collections.Generic;

namespace ServiceLayer.Interfaces
{
    public interface IProductService
    {
        IEnumerable<CategoryDTO> GetCategories();
        CategoryDTO GetCategory(int id);
        IEnumerable<SubCategoryDTO> GetSubCategories();
        SubCategoryDTO GetSubCategory(int id);
        ProductDTO GetProduct(int id);
        CompareDTO GetCompares(string idList);
    }
}