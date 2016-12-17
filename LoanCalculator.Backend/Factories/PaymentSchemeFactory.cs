using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.General.PaymentSchemes;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Factories
{
    public static class PaymentSchemeFactory
    {
        public static IPaymentScheme GetInstance(PaymentSchemeEnum paymentSchemeId)
        {
            IPaymentScheme paymentScheme = null;
            switch (paymentSchemeId)
            {
                case PaymentSchemeEnum.Monthly:
                    paymentScheme = new MonthlyPaymentScheme();
                    break;
            }

            return paymentScheme;
        }
    }
}
