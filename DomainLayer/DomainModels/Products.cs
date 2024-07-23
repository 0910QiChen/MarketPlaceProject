using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DomainLayer.DomainModels
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategories SubCategory { get; set; }
        public virtual ICollection<AttributeDetails> AttributeDetails { get; set; }
        public virtual ICollection<KeySpec> KeySpecs { get; set; }
    }
}