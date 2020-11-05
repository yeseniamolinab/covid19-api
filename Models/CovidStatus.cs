using System;
using Newtonsoft.Json;

namespace covid19_api.Models
{
    public class CovidStatus
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the last updated.
        /// </summary>
        /// <value>
        /// The last updated.
        /// </value>
        [JsonProperty("last_update")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the cases.
        /// </summary>
        /// <value>
        /// The cases.
        /// </value>
        public int Cases { get; set; }

        /// <summary>
        /// Gets or sets the deaths.
        /// </summary>
        /// <value>
        /// The deaths.
        /// </value>
        public int Deaths { get; set; }

        /// <summary>
        /// Gets or sets the recovered.
        /// </summary>
        /// <value>
        /// The recovered.
        /// </value>
        public int Recovered { get; set; }
    }
}