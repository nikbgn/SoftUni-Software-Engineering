using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Prisoner")]
    public class PrisonerIdModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
