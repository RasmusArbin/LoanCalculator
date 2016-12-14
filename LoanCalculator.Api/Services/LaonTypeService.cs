using System.Collections.Generic;
using LoanCalculator.Api.Models;

namespace LoanCalculator.Api.Services
{
    public class LaonTypeService: LoanCalculatorService
    {
        public List<LoanTypeModel> GetAllLoanTypes()
        {
            return new List<LoanTypeModel>()
            {
                new LoanTypeModel()
                {
                    Name = "Huslån",
                    Percent = 3.5
                }
            };
        }
    }
}