using Newtonsoft.Json;

namespace LoanCalculator.Api.Models
{
    public class PaymentPlanItemModel
    {
        [JsonProperty(PropertyName = "monthNumber")]
        public int MonthNumber { get; set; }
        [JsonProperty(PropertyName = "interest")]
        public double Interest { get; set; }
        [JsonProperty(PropertyName = "amortization")]
        public double Amortization { get; set; }
    }
}