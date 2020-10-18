using Newtonsoft.Json;

namespace CNX.TEST
{
    public class AddressInfo    {
        [JsonProperty("Address")]
        public string Address { get; set; } 

        [JsonProperty("City")]
        public City City { get; set; } 
    }
}