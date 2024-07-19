using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class SubCategoryDTO
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryID { get; set; }
        public CategoryDTO Category { get; set; }
        public virtual ICollection<ProductDTO> Products { get; set; }
        public virtual ICollection<AttributeDTO> Attributes { get; set; }
    }
}