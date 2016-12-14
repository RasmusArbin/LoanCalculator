using System.Web.Http;
using LoanCalculator.Api.Providers;

namespace LoanCalculator.Api.Controllers
{
    public class LoanCalculatorApiController: ApiController
    {
        public LoanCalculatorServiceProvider ServiceProvider { get; set; }

        public LoanCalculatorApiController()
        {
            ServiceProvider = new LoanCalculatorServiceProvider();
        }
    }
}