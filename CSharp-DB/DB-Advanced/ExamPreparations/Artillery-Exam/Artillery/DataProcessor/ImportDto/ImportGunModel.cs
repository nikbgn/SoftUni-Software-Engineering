using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Artillery.DataProcessor.ImportDto
{
    public class ImportGunModel
    {
        [JsonProperty(nameof(ManufacturerId))]
        public int ManufacturerId { get; set; }

        [Range(100,1_350_000)]
        [JsonProperty(nameof(GunWeight))]
        public int GunWeight { get; set; }

        [Range(2.00, 35.00)]
        [JsonProperty(nameof(BarrelLength))]
        public double BarrelLength { get; set; }

        [JsonProperty(nameof(NumberBuild))]
        public int? NumberBuild { get; set; }

        [Range(1, 100_000)]
        [JsonProperty(nameof(Range))]
        public int Range { get; set; }

        [Required]
        [JsonProperty(nameof(GunType))]
        public string GunType { get; set; }

        [JsonProperty(nameof(ShellId))]
        public int ShellId { get; set; }

        [JsonProperty(nameof(Countries))]
        public CountryModel[] Countries { get; set; }

    }
}
