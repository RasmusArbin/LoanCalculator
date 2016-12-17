using System;
using Newtonsoft.Json;

namespace LoanCalculator.Api.Models
{
    public class PaymentSchemeTypeModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}