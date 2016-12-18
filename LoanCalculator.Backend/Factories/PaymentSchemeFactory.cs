using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.Interfaces;
using LoanCalculator.Backend.PaymentSchemes;

namespace LoanCalculator.Backend.Factories
{
    /// <summary>
    /// Factory class to create a instance of IPaymentScheme based on PaymentSchemeTypeEnum
    /// </summary>
    public static class PaymentSchemeFactory
    {
        public static IPaymentScheme GetInstance(PaymentSchemeTypeEnum paymentSchemeId)
        {
            IPaymentScheme paymentScheme = null;
            switch (paymentSchemeId)
            {
                case PaymentSchemeTypeEnum.Monthly:
                    paymentScheme = new MonthlyPaymentScheme();
                    break;
            }

            return paymentScheme;
        }
    }
}
