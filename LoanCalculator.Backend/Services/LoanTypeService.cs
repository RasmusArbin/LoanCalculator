using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.General;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService
    {
        private static List<LoanTypeBO> _loanTypes = new List<LoanTypeBO>
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
        public List<LoanTypeBO> GetAllLoanTypes()
        {
            return _loanTypes;
        }

        public LoanTypeBO GetByGuid(Guid loanTypeGuid)
        {
            return _loanTypes.Find(lt => lt.Guid == loanTypeGuid);
        }
        
        public List<PaymentPlanItem> CalculatePaymentPlan(Guid loanTypeGuid, double loanAmount, int yearCount)
        {
            LoanTypeBO loanType = GetByGuid(loanTypeGuid);

            int monthCount = GetMonth(yearCount);

            List<PaymentPlanItem> paymentPlanItems = new List<PaymentPlanItem>();
            
            double amortization = loanAmount / monthCount;
            for (int i = 0; i < monthCount; i++)
            {
                double interest = loanAmount * loanType.Percent / 100 / 12;
                loanAmount -= amortization;
                paymentPlanItems.Add(new PaymentPlanItem()
                {
                    MonthNumber = i + 1,
                    Amortization = amortization,
                    Interest = interest
                });
            }

            return paymentPlanItems;
        }

        private int GetMonth(int years)
        {
            return years*12;
        }
    }
}