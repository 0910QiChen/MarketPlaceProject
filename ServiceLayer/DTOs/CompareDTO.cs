using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class CompareDTO
    {
        public IEnumerable<CategoryDTO> Categories { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}