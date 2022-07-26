namespace ProductShop.DTOs.User
{
    using Newtonsoft.Json;

    [JsonObject]

    public class ExportUsersWithFullProductInfo
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }


    }
}
