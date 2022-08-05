﻿namespace TeisterMask.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Task")]

    public class ExportTaskModel
    {
        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [XmlElement(nameof(Label))]
        public string Label { get; set; }
    }
}
