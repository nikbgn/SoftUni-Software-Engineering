using Newtonsoft.Json;
using SoftJail.Data;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class CellInfoModel
    {
        [JsonProperty(nameof(CellNumber))]
        [Range(ValidationConstants.CellNumberMinValue,ValidationConstants.CellNumberMaxValue)]
        public int CellNumber { get; set; }

        [JsonProperty(nameof(HasWindow))]
        public bool HasWindow { get; set; }
    }
}
