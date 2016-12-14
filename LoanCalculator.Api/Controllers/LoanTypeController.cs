using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LoanCalculator.Api.Models;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Services;

namespace LoanCalculator.Api.Controllers
{
    [RoutePrefix("Api/LoanTypes")]
    public class LoanTypeController: LoanCalculatorApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<LoanTypeModel> GetAllLoanTypes()
        {
            return ServiceProvider.GetService<LoanTypeService>().GetAllLoanTypes().Select(l => new LoanTypeModel()
            {
                Id = l.Guid,
                Name = l.Name,
                Percent = l.Percent
            });
        }

        [Route("CalculatePaymentPlan")]
        [HttpGet]
        public IEnumerable<PaymentPlanItemModel> CalculatePaymentPlan(Guid loanTypeId, double loanAmount, int yearCount)
        {
            return ServiceProvider.GetService<LoanTypeService>()
                .CalculatePaymentPlan(loanTypeId, loanAmount, yearCount)
                .Select(p => new PaymentPlanItemModel()
                {
                    Amortization = p.Amortization,
                    Interest = p.Interest,
                    MonthNumber = p.MonthNumber
                });
        }
    }
}