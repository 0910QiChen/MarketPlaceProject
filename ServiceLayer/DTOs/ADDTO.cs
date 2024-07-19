namespace ServiceLayer.DTOs
{
    public class ADDTO
    {
        public int DetailID { get; set; }
        public int AttributeID { get; set; }
        public int ProductID { get; set; }
        public string Details { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public AttributeDTO AttributeDTO { get; set; }
    }
}