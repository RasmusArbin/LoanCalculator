using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.General;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService
    {
        const int MONTHS_IN_YEAR = 12;
        private static List<LoanTypeBO> _loanTypes = new List<LoanTypeBO>
        {
            new LoanTypeBO()
            {
                LoanTypeId = (int) LoanTypeEnum.HouseLoan,
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
                double interest = loanAmount*GetPecentAsDecimal(loanType.Percent)/MONTHS_IN_YEAR;
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
            return years*MONTHS_IN_YEAR;
        }

        private double GetPecentAsDecimal(double percent)
        {
            return percent/100;
        }
    }
}