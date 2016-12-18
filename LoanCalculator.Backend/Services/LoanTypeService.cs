using System;
using System.Collections.Generic;
using System.Linq;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.Factories;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService<LoanTypeBO>
    {
        public LoanTypeBO GetByGuid(Guid loanTypeGuid)
        {
            return MainRepository.GetAll().First(lt => lt.Guid == loanTypeGuid);
        }
        
        public List<PaymentPlanItem> CalculatePaymentPlan(LoanTypeBO loanType, PaymentSchemeTypeBO paymentSchemeType, double loanAmount, int yearCount)
        {
            IPaymentScheme paymentScheme = PaymentSchemeFactory.GetInstance((PaymentSchemeTypeEnum) paymentSchemeType.Id);

            return paymentScheme.CalculatePaymentPlan(loanType, loanAmount, yearCount);
        }
    }
}