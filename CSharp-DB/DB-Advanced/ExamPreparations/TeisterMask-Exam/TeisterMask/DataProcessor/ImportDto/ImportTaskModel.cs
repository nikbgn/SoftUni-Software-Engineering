namespace TeisterMask.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Task")]

    public class ImportTaskModel
    {

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [Required]
        [XmlElement(nameof(OpenDate))]
        public string OpenDate { get; set; }

        [Required]
        [XmlElement(nameof(DueDate))]
        public string DueDate { get; set; }

        [Required]
        [XmlElement(nameof(ExecutionType))]
        public string ExecutionType { get; set; }

        [Required]
        [XmlElement(nameof(LabelType))]
        public string LabelType { get; set; }
    }
}
