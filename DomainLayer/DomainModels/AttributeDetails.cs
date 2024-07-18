using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModels
{
    public class AttributeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailID {  get; set; }
        [Required]
        public int AttributeID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public string Details { get; set; }
        public Products Product {  get; set; }
        public Attributes Attribute { get; set; }
    }
}