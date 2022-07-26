namespace ProductShop.DTOs.User
{
    using Newtonsoft.Json;

    [JsonObject]

    public class ExportUsersInfoDto
    {
        [JsonProperty("usersCount")]
        public int UsersCount { get; set; }
    }
}
