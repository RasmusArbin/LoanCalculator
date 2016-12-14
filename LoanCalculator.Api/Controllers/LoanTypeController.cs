using System.Collections.Generic;
using System.Web.Http;
using LoanCalculator.Api.Models;
using LoanCalculator.Api.Services;

namespace LoanCalculator.Api.Controllers
{
    public class LoanTypeController: LoanCalculatorApiController
    {
        [HttpGet]
        public List<LoanTypeModel> GetAllLoanTypes()
        {
            return ServiceProvider.GetService<LaonTypeService>().GetAllLoanTypes();
        }
    }
}