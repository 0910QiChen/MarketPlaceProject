using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
