
using System.Xml.Serialization;

namespace ProductShop.Dtos.Export
{

    public class BigUserProductModel
    {

        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public UserAndProductModel[] Users { get; set; }

    }
}
