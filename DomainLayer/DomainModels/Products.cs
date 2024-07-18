using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.DomainModels
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string SubCategory {  get; set; }
        [Required]
        public string Category {  get; set; }
        public string ModelName { get; set; }
        public int ModelYear {  get; set; }
    }
}