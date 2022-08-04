namespace Theatre.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Actor")]

    public class ExportActorModel
    {
        [XmlAttribute(nameof(FullName))]
        public string FullName { get; set; }

        [XmlAttribute(nameof(MainCharacter))]
        public string MainCharacter { get; set; }
    }
}
