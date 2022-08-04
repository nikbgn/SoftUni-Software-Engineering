
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Theatre.DataProcessor.ImportDto
{

    public class ImportProjectionsModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [JsonProperty(nameof(Name))]
        public string Name { get; set; }

        [Range(1,10)]
        [JsonProperty(nameof(NumberOfHalls))]
        public sbyte NumberOfHalls { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [JsonProperty(nameof(Director))]
        public string Director { get; set; }

        [JsonProperty(nameof(Tickets))]
        public ImportTicketModel[] Tickets { get; set; }
    }
}
