using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LoanCalculator.Api.Models;
using LoanCalculator.Backend.Services;

namespace LoanCalculator.Api.Controllers
{
    public class LoanTypeController: LoanCalculatorApiController
    {
        [HttpGet]
        public IEnumerable<LoanTypeModel> GetAllLoanTypes()
        {
            return ServiceProvider.GetService<LaonTypeService>().GetAllLoanTypes().Select(l => new LoanTypeModel()
            {
                Id = l.Guid,
                Name = l.Name,
                Percent = l.Percent
            });
        }
    }
}