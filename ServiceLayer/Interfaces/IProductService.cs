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
        SearchDTO GetSearches(int id);
        CompareDTO GetCompares(string idList);
        List<ProductDTO> GetFilters(int id, Dictionary<int, string> filters);
        IEnumerable<KeySpecDTO> GetKeySpecsByProductId(int productId);
    }
}