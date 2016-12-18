using System;
using System.Linq;
using LoanCalculator.Backend.BO;

namespace LoanCalculator.Backend.Services
{
    public class PaymentSchemeTypeService : LoanCalculatorService<PaymentSchemeTypeBO>
    {
        public PaymentSchemeTypeBO GetByGuid(Guid paymentSchemeTypeGuid)
        {
            return MainRepository.GetAll().FirstOrDefault(lt => lt.Guid == paymentSchemeTypeGuid);
        }
    }
}