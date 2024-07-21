using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class CategoryVM
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<SubCategoryVM> SubCategories { get; set; }
    }
}