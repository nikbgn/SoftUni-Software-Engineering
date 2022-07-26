namespace ProductShop.DTOs.Product
{
    using Newtonsoft.Json;

    [JsonObject]

    public class ExportSoldProductsFullInfoDto
    {
        [JsonProperty("count")]
        public int ProductsCount { get; set; }

        [JsonProperty("products")]
        public ExportSoldProductShortInfoDto[] SoldProducts { get; set; }


    }
}
