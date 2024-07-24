using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.DomainModels
{
    public class KeySpec
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeySpecID { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }

        public int ProductID { get; set; }
        public Products Product { get; set; }
    }
}