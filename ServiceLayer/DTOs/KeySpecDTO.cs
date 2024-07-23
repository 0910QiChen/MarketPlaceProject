using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs
{
    public class KeySpecDTO
    {
        public int KeySpecID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int ProductID { get; set; }
    }
}
