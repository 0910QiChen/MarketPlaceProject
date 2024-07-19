namespace MarketPlaceProject.ViewModels
{
    public class ADVM
    {
        public int DetailID { get; set; }
        public int AttributeID { get; set; }
        public int ProductID { get; set; }
        public string Details { get; set; }
        public ProductVM Product { get; set; }
        public AttributeVM Attribute { get; set; }
    }
}