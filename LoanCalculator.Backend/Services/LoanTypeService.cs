using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.General;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService
    {
        private static List<LoanTypeBO> _loanTypes = new List<LoanTypeBO>
        {
            new LoanTypeBO()
            {
                LoanTypeId = (int) LoneTypeEnum.HouseLone,
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

            double copiedLoanAmount = loanAmount;
            int monthCount = GetMonth(yearCount);

            List<PaymentPlanItem> paymentPlanItems = new List<PaymentPlanItem>();
            
            for (int i = 0; i < monthCount; i++)
            {
                double amortization = GetAmortization(loanType.LoanTypeId, loanAmount, monthCount, i + 1);
                double interest = copiedLoanAmount * loanType.Percent / 100 / 12;
                copiedLoanAmount -= amortization;
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

        private double GetAmortization(int loneTypeId, double totalamount, int monthCount, int currentMonth)
        {
            double amortization = 0;
            switch ((LoneTypeEnum) loneTypeId)
            {
                case LoneTypeEnum.HouseLone:
                    amortization = totalamount/monthCount;
                    break;
            }
            return amortization;
        }
    }
}