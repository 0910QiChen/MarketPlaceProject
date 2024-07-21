using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class SubCategoryVM
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryID { get; set; }
        public CategoryVM Category { get; set; }
        public virtual ICollection<ProductVM> Products { get; set; }
        public virtual ICollection<AttributeVM> Attributes { get; set; }
    }
}