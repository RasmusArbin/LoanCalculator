using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;

namespace LoanCalculator.Backend.Services
{
    public class LaonTypeService: LoanCalculatorService
    {
        private static LoanTypeBO _loanType = new LoanTypeBO()
        {
            LoanTypeId = 1,
            Guid = Guid.NewGuid(),
            Name = "Huslån",
            Percent = 3.5,
            Created = DateTime.Now,
            Modified = DateTime.Now
        };
        public List<LoanTypeBO> GetAllLoanTypes()
        {
            return new List<LoanTypeBO>()
            {
                _loanType
            };
        }

        public LoanTypeBO GetById()
        {
            return _loanType;
        }
    }
}