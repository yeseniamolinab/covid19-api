using System;

namespace covid19_api.Models
{
    public class CovidPrediction
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the cases.
        /// </summary>
        /// <value>
        /// The cases.
        /// </value>
        public int Cases { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }
    }
}