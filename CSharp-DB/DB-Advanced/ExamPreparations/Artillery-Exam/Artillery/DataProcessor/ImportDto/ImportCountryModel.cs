namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Country")]

    public class ImportCountryModel
    {
        [Required]
        [MinLength(ValidationConstants.CountryNameMinLength)]
        [MaxLength(ValidationConstants.CountryNameMaxLength)]
        [XmlElement(nameof(CountryName))]
        public string CountryName { get; set; }

        [Range(ValidationConstants.ArmySizeMinRange,ValidationConstants.ArmySizeMaxRange)]
        [XmlElement(nameof(ArmySize))]
        public int ArmySize { get; set; }
    }
}
