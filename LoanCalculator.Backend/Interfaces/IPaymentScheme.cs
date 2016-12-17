using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.General;

namespace LoanCalculator.Backend.Interfaces
{
    public interface IPaymentScheme
    {
        List<PaymentPlanItem> CalculatePaymentPlan(LoanTypeBO loanType, double loanAmount, int yearCount);
    }
}
