namespace Artillery.DataProcessor.ExportDto
{

    using System.Xml.Serialization;

    [XmlType("Country")]

    public class ExportCountryModel
    {
        [XmlAttribute(nameof(Country))]
        public string Country { get; set; }

        [XmlAttribute(nameof(ArmySize))]
        public int ArmySize { get; set; }
    }
}
