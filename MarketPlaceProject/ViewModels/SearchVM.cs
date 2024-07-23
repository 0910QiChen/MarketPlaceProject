using ServiceLayer.DTOs;
using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class SearchVM
    {
        public IEnumerable<CategoryVM> Categories { get; set; }
        public SubCategoryVM SubCategory { get; set; }
        public List<KeySpecDTO> KeySpecs { get; set; }
    }
}