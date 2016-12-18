using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LoanCalculator.Api.Models;
using LoanCalculator.Backend.Services;

namespace LoanCalculator.Api.Controllers
{
    [RoutePrefix("Api/PaymentSchemeTypes")]
    public class PaymentSchemeTypeController : LoanCalculatorApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<PaymentSchemeTypeModel> GetAllPaymentSchemes()
        {
            return
                ServiceProvider.GetService<PaymentSchemeTypeService>()
                    .GetAll()
                    .Select(l => new PaymentSchemeTypeModel()
                    {
                        Id = l.Guid,
                        Name = l.Name
                    });
        }
    }
}