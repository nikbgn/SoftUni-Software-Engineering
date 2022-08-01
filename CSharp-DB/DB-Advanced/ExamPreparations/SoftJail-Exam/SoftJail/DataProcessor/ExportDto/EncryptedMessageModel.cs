using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ExportDto
{
    [XmlType("Message")]

    public class EncryptedMessageModel
    {
        [Required]
        [XmlElement(nameof(Description))]
        public string Description { get; set; }
    }
}
