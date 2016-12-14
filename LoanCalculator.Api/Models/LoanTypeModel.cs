using System;
using Newtonsoft.Json;

namespace LoanCalculator.Api.Models
{
    public class LoanTypeModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "percent")]
        public double Percent { get; set; }
    }
}