using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;

namespace LoanCalculator.Backend.Services
{
    public class LaonTypeService: LoanCalculatorService
    {
        public List<LoanTypeBO> GetAllLoanTypes()
        {
            return new List<LoanTypeBO>()
            {
                new LoanTypeBO()
                {
                    LoanTypeId = 1,
                    Guid = Guid.NewGuid(),
                    Name = "Huslån",
                    Percent = 3.5,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            };
        }
    }
}