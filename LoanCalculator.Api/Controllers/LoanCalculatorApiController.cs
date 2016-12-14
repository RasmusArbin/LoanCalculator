using System.Web.Http;
using LoanCalculator.Backend.Providers;

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