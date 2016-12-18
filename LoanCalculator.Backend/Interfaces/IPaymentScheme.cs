using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.General;

namespace LoanCalculator.Backend.Interfaces
{
    /// <summary>
    /// Interface for the different CalculatePaymentPlan implemenetations.
    /// This to make the program flexible for other types of payment plans
    /// </summary>
    public interface IPaymentScheme
    {
        List<PaymentPlanItem> CalculatePaymentPlan(LoanTypeBO loanType, double loanAmount, int yearCount);
    }
}
