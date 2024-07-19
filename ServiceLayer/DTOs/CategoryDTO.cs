using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<SubCategoryDTO> SubCategories { get; set; }
    }
}