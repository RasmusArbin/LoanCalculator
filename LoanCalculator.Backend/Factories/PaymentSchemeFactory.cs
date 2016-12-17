using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.General.PaymentSchemes;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Factories
{
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
