namespace ProductShop.Dtos.Import
{
    using System.Xml.Serialization;

    [XmlType("Category")]

    public class ImportCategoryModel
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}

/*
    <Category>
        <name>Drugs</name>
    </Category>
 */