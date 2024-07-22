using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class CompareVM
    {
        public IEnumerable<CategoryVM> Categories { get; set; }
        public SubCategoryVM SubCategory { get; set; }
        public IEnumerable<ProductVM> Products { get; set; }
    }
}