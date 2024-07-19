using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public virtual ICollection<ADDTO> AttributeDetails { get; set; }
    }
}