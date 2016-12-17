using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;

namespace LoanCalculator.Backend.Services
{
    public class PaymentSchemeTypeService : LoanCalculatorService
    {
        private static List<PaymentSchemeTypeBO> _paymentSchemeTypes = new List<PaymentSchemeTypeBO>
        {
            new PaymentSchemeTypeBO()
            {
                PaymentSchemeTypeId = (int) PaymentSchemeTypeEnum.Monthly,
                Guid = Guid.NewGuid(),
                Name = "Monthly",
                Created = DateTime.Now,
                Modified = DateTime.Now
            }
        };

        public List<PaymentSchemeTypeBO> GetAllPaymentSchemes()
        {
            return _paymentSchemeTypes;
        }

        public PaymentSchemeTypeBO GetByGuid(Guid paymentSchemeTypeGuid)
        {
            return _paymentSchemeTypes.Find(lt => lt.Guid == paymentSchemeTypeGuid);
        }
    }
}