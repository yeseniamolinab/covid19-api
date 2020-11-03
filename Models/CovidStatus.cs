using System;
using Newtonsoft.Json;

namespace covid19_api.Models
{
    public class CovidStatus
    {
        public string Country { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        public int Cases { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }
    }
}