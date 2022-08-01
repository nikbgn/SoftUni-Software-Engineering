using Newtonsoft.Json;
using SoftJail.Data;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportPrisonersMailsModel
    {
        [Required]
        [MinLength(ValidationConstants.PrisonerFullNameMinLength)]
        [MaxLength(ValidationConstants.PrisonerFullNameMaxLength)]
        [JsonProperty(nameof(FullName))]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(ValidationConstants.NicknameRegex)]
        [JsonProperty(nameof(NickName))]
        public string NickName { get; set; }

        [Range(ValidationConstants.PrisonerMinAge,ValidationConstants.PrisonerMaxAge)]
        [JsonProperty(nameof(Age))]
        public int Age { get; set; }

        [Required]
        [JsonProperty(nameof(IncarcerationDate))]
        public string IncarcerationDate { get; set; }

        [JsonProperty(nameof(ReleaseDate))]
        public string ReleaseDate { get; set; }

        [Range(typeof(decimal),ValidationConstants.BailMinValue,ValidationConstants.BailMaxValue)]
        [JsonProperty(nameof(Bail))]
        public decimal? Bail { get; set; }

        [JsonProperty(nameof(CellId))]
        public int? CellId { get; set; }

        [JsonProperty(nameof(Mails))]
        public PrisonerMailInfoModel[] Mails { get; set; }
    }
}
