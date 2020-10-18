
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CNX.TEST
{
    public class Person    {
        [JsonProperty("UserName")]
        public string UserName { get; set; } 

        [JsonProperty("FirstName")]
        public string FirstName { get; set; } 

        [JsonProperty("LastName")]
        public string LastName { get; set; } 

        [JsonProperty("MiddleName")]
        public string MiddleName { get; set; } 

        [JsonProperty("Gender")]
        public string Gender { get; set; } 

        [JsonProperty("Age")]
        public int? Age { get; set; } 

        [JsonProperty("Emails")]
        public List<string> Emails { get; set; } 

        [JsonProperty("FavoriteFeature")]
        public string FavoriteFeature { get; set; } 

        [JsonProperty("Features")]
        public List<string> Features { get; set; } 

        [JsonProperty("AddressInfo")]
        public List<AddressInfo> AddressInfo { get; set; } 

        [JsonProperty("HomeAddress")]
        public AddressInfo HomeAddress { get; set; } 

        [JsonProperty("Budget")]
        public int? Budget { get; set; } 

        [JsonProperty("BossOffice")]
        public string BossOffice { get; set; } 

        [JsonProperty("Cost")]
        public int? Cost { get; set; } 
    }
}