using System.Xml.Serialization;
namespace Artillery.DataProcessor.ExportDto
{
    [XmlType("Gun")]
    public class ExportGunModel
    {
        [XmlAttribute(nameof(Manufacturer))]
        public string Manufacturer { get; set; }

        [XmlAttribute(nameof(GunType))]
        public string GunType { get; set; }

        [XmlAttribute(nameof(GunWeight))]
        public int GunWeight { get; set; }

        [XmlAttribute(nameof(BarrelLength))]
        public double BarrelLength { get; set; }

        [XmlAttribute(nameof(Range))]
        public int Range { get; set; }

        [XmlArray(nameof(Countries))]
        public ExportCountryModel[] Countries { get; set; }



    }
}
