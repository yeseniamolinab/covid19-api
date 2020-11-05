using System;

namespace covid19_api.Models
{
    public class CovidPrediction
    {
        public string Country { get; set; }

        public int Cases { get; set; }

        public DateTime Date { get; set; }
    }
}
