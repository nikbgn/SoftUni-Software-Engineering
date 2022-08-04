namespace Theatre.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Play")]

    public class ExportPlaysModel
    {
        [XmlAttribute(nameof(Title))]
        public string Title { get; set; }

        [XmlAttribute(nameof(Duration))]
        public string Duration { get; set; }

        [XmlAttribute(nameof(Rating))]
        public string Rating { get; set; }

        [XmlAttribute(nameof(Genre))]
        public string Genre { get; set; }

        [XmlArray(nameof(Actors))]
        public ExportActorModel[] Actors { get; set; }
    }
}
