namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Cast")]

    public class ImportCastsModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [XmlElement(nameof(FullName))]
        public string FullName { get; set; }

        [XmlElement(nameof(IsMainCharacter))]
        public bool IsMainCharacter { get; set; }

        [Required]
        [RegularExpression(@"^(\+44-)(\d{2}-)(\d{3})-(\d{4})$")]
        [XmlElement(nameof(PhoneNumber))]
        public string PhoneNumber { get; set; }

        [XmlElement(nameof(PlayId))]
        public int PlayId { get; set; }

    }
}
