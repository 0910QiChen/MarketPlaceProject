using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarketPlaceProject.ViewModels
{
    public class AttributeVM
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryVM SubCategory { get; set; }
        public virtual ICollection<ADVM> AttributeDetails { get; set; }

        public int? MinIntValue
        {
            get
            {
                if (AttributeType != "integer")
                    return null;

                return AttributeDetails
                    .Select(ad => int.Parse(Regex.Replace(ad.Details, @"[^\d]", "")))
                    .Min();
            }
        }
        public int? MaxIntValue
        {
            get
            {
                if (AttributeType != "integer")
                    return null;

                return AttributeDetails
                    .Select(ad => int.Parse(Regex.Replace(ad.Details, @"[^\d]", "")))
                    .Max();
            }
        }
        public float? MinFloatValue
        {
            get
            {
                if (AttributeType != "float")
                    return null;

                return AttributeDetails
                    .Select(ad => float.Parse(Regex.Match(ad.Details, @"-?\d+(\.\d+)?").Value))
                    .DefaultIfEmpty()
                    .Min();
            }
        }
        public float? MaxFloatValue
        {
            get
            {
                if (AttributeType != "float")
                    return null;

                return AttributeDetails
                    .Select(ad => float.Parse(Regex.Match(ad.Details, @"-?\d+(\.\d+)?").Value))
                    .DefaultIfEmpty()
                    .Max();
            }
        }
    }
}