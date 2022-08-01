namespace SoftJail.DataProcessor.ExportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Prisoner")]

    public class ExportPrisonersModel
    {
        [XmlElement(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [XmlElement(nameof(IncarcerationDate))]
        public string IncarcerationDate { get; set; }

        [XmlArray(nameof(EncryptedMessages))]
        public EncryptedMessageModel[] EncryptedMessages { get; set; }
    }
}
