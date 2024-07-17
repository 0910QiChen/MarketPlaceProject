using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SubCategory { get; set; }
        public string Category { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
    }
}