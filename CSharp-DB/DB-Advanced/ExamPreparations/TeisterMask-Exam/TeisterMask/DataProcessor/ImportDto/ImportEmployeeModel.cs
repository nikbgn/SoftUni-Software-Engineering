namespace TeisterMask.DataProcessor.ImportDto
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    public class ImportEmployeeModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        [JsonProperty(nameof(Username))]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty(nameof(Email))]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{3})\-([0-9]{3})\-([0-9]{4})$")]
        [JsonProperty(nameof(Phone))]
        public string Phone { get; set; }

        public int[] Tasks { get; set; }
    }
}
