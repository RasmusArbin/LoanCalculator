using System;

namespace LoanCalculator.Api.Models
{
    public class LoanTypeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
    }
}