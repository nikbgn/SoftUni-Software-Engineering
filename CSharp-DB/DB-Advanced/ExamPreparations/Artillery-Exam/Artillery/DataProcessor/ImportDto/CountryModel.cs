using Newtonsoft.Json;

namespace Artillery.DataProcessor.ImportDto
{
    public class CountryModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }
    }
}
