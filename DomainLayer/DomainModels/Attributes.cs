using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int SubCategoryID { get; set; }
        public SubCategories SubCategory { get; set; }
        public virtual ICollection<AttributeDetails> AttributeDetails { get; set; }
    }
}
