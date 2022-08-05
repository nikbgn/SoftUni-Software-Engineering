namespace TeisterMask.DataProcessor.ImportDto
{
    using Newtonsoft.Json;
    public class ImportTaskIdModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }
    }
}
