using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.DomainModels
{
    public class SubCategories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryID { get; set; }
        [Required]
        public string SubCategoryName { get; set; }
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}