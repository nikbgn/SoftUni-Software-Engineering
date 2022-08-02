namespace Artillery.DataProcessor.ImportDto
{
    using Artillery.Data;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Shell")]

    public class ImportShellModel
    {
        [Range(ValidationConstants.ShellWeightMin, ValidationConstants.ShellWeightMax)]
        public double ShellWeight { get; set; }

        [Required]
        [MinLength(ValidationConstants.CaliberMinLength)]
        [MaxLength(ValidationConstants.CaliberMaxLength)]
        public string Caliber { get; set; }
    }
}
