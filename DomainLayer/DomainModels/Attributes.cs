using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.DomainModels
{
    public class Attributes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttributeID { get; set; }
        [Required]
        public string AttributeName { get; set; }
        [Required]
        public string AttributeType { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategories SubCategory { get; set; }
        public virtual ICollection<AttributeDetails> AttributeDetails { get; set; }
    }
}