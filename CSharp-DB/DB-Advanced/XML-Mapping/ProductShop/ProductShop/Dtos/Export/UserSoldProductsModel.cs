namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("User")]

    public class UserSoldProductsModel
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlArray("soldProducts")]
        public ProductNamePriceModel[] SoldProducts { get; set; }
    }
}
