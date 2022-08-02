namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Manufacturer")]

    public class ImportManufacturerModel
    {
        [Required]
        [MinLength(ValidationConstants.ManufacturerNameMinLength)]
        [MaxLength(ValidationConstants.ManufacturerNameMaxLength)]
        public string ManufacturerName { get; set; }

        [Required]
        [MinLength(ValidationConstants.ManufacturerFoundedMinLength)]
        [MaxLength(ValidationConstants.ManufacturerFoundedMaxLength)]
        public string Founded { get; set; }
    }
}
