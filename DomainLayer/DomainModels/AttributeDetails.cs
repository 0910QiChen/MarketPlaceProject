using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.DomainModels
{
    public class AttributeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailID {  get; set; }
        public int AttributeID { get; set; }
        public int ProductID { get; set; }
        [Required]
        public string Details { get; set; }
        public Products Product { get; set; }
        public Attributes Attribute { get; set; }
    }
}