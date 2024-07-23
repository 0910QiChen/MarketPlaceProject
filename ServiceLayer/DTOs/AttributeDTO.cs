using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOs
{
    public class AttributeDTO
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public virtual ICollection<ADDTO> AttributeDetails { get; set; }
    }
}