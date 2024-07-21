using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class AttributeVM
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryVM SubCategory { get; set; }
        public virtual ICollection<ADVM> AttributeDetails { get; set; }
    }
}