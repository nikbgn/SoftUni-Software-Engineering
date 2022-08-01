using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Officer")]

    public class ImportOfficerPrisonerModel
    {
        [Required]
        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [XmlElement(nameof(Money))]
        public decimal Money { get; set; }

        [Required]
        [XmlElement(nameof(Position))]
        public string Position { get; set; }

        [Required]
        [XmlElement(nameof(Weapon))]
        public string Weapon { get; set; }

        [XmlElement(nameof(DepartmentId))]
        public int DepartmentId { get; set; }

        [XmlArray(nameof(Prisoners))]
        public PrisonerIdModel[] Prisoners { get; set; }
    }
}
