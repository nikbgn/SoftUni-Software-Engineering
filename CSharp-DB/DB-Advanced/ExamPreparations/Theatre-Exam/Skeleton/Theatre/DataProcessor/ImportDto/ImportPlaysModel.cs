namespace Theatre.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Play")]

    public class ImportPlaysModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        [XmlElement(nameof(Title))]
        public string Title { get; set; }

        [Required]
        [XmlElement(nameof(Duration))]
        public string Duration { get; set; }

        [Range(typeof(float),"0.00","10.00")]
        [XmlElement(nameof(Rating))]
        public float Rating { get; set; }

        [Required]
        [XmlElement(nameof(Genre))]
        public string Genre { get; set; }

        [Required]
        [MaxLength(700)]
        [XmlElement(nameof(Description))]
        public string Description { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [XmlElement(nameof(Screenwriter))]
        public string Screenwriter { get; set; }
    }
}
