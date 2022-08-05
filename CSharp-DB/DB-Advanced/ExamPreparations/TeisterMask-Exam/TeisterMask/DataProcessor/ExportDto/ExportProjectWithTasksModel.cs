namespace TeisterMask.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Project")]

    public class ExportProjectWithTasksModel
    {
        [XmlAttribute(nameof(TasksCount))]
        public int TasksCount { get; set; }

        [XmlElement(nameof(ProjectName))]
        public string ProjectName { get; set; }

        [XmlElement(nameof(HasEndDate))]
        public string HasEndDate { get; set; }

        [XmlArray(nameof(Tasks))]
        public ExportTaskModel[] Tasks { get; set; }
    }
}
