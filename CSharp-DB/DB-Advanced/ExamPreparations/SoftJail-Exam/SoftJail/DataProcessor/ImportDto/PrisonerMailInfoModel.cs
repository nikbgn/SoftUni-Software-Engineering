namespace SoftJail.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using SoftJail.Data;

    public class PrisonerMailInfoModel
    {
        [Required]
        [JsonProperty(nameof(Description))]
        public string Description { get; set; }

        [Required]
        [JsonProperty(nameof(Sender))]
        public string Sender { get; set; }

        [Required]
        [JsonProperty(nameof(Address))]
        [RegularExpression(ValidationConstants.AddressRegex)]
        public string Address { get; set; }

    }
}
