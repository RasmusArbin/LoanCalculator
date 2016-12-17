using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.Factories;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService
    {
        private static List<LoanTypeBO> _loanTypes = new List<LoanTypeBO>
        {
            new LoanTypeBO()
            {
                LoanTypeId = (int) LoanTypeEnum.HouseLoan,
                Guid = Guid.NewGuid(),
                Name = "House loan",
                Percent = 3.5,
                Created = DateTime.Now,
                Modified = DateTime.Now
            }
        };
        public List<LoanTypeBO> GetAllLoanTypes()
        {
            return _loanTypes;
        }

        public LoanTypeBO GetByGuid(Guid loanTypeGuid)
        {
            return _loanTypes.Find(lt => lt.Guid == loanTypeGuid);
        }
        
        public List<PaymentPlanItem> CalculatePaymentPlan(LoanTypeBO loanType, PaymentSchemeTypeBO paymentSchemeType, double loanAmount, int yearCount)
        {
            IPaymentScheme paymentScheme = PaymentSchemeFactory.GetInstance((PaymentSchemeTypeEnum) paymentSchemeType.Id);

            return paymentScheme.CalculatePaymentPlan(loanType, loanAmount, yearCount);
        }
    }
}