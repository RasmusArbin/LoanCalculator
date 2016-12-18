using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.PaymentSchemes
{
    public class MonthlyPaymentScheme: IPaymentScheme
    {
        const int MONTHS_IN_YEAR = 12;
        public List<PaymentPlanItem> CalculatePaymentPlan(LoanTypeBO loanType, double loanAmount, int yearCount)
        {
            int monthCount = GetMonthCount(yearCount);

            List<PaymentPlanItem> paymentPlanItems = new List<PaymentPlanItem>();

            double amortization = loanAmount / monthCount;
            for (int i = 0; i < monthCount; i++)
            {
                double interest = loanAmount * GetPecentAsDecimal(loanType.Percent) / MONTHS_IN_YEAR;
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

        private int GetMonthCount(int years)
        {
            return years * MONTHS_IN_YEAR;
        }

        private double GetPecentAsDecimal(double percent)
        {
            return percent / 100;
        }
    }
}
