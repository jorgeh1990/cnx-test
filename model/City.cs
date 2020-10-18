using Newtonsoft.Json;

namespace CNX.TEST
{
    public class City    {
        [JsonProperty("Name")]
        public string Name { get; set; } 

        [JsonProperty("CountryRegion")]
        public string CountryRegion { get; set; } 

        [JsonProperty("Region")]
        public string Region { get; set; } 
    }
}