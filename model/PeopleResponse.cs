using System.Collections.Generic;
using Newtonsoft.Json;

namespace CNX.TEST
{
    public class PeopleResponse    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; } 

        [JsonProperty("value")]
        public List<Person> People { get; set; } 
    }
}