namespace SoftJail.DataProcessor.ImportDto
{
    using Newtonsoft.Json;
    using SoftJail.Data;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ImportDepartmentsCellsModel
    {
        [JsonProperty(nameof(Name))]
        [MinLength(ValidationConstants.DepartmentNameMinLength)]
        [MaxLength(ValidationConstants.DepartmentNameMaxLength)]
        public string Name { get; set; }

        [JsonProperty(nameof(Cells))]
        public CellInfoModel[] Cells { get; set; }
    }
}
