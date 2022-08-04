namespace Theatre.DataProcessor.ImportDto
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class ImportTicketModel
    {
        [Range(1.00,100.00)]
        [JsonProperty(nameof(Price))]
        public decimal Price { get; set; }

        [Range(1,10)]
        [JsonProperty(nameof(RowNumber))]
        public sbyte RowNumber { get; set; }

        [JsonProperty(nameof(PlayId))]
        public int PlayId { get; set; }


    }
}
