using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class AttributeDTO
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public virtual ICollection<ADDTO> AttributeDetails { get; set; }
    }
}