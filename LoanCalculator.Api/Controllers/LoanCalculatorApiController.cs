using System.Web.Http;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;
using LoanCalculator.Backend.Providers;

namespace LoanCalculator.Api.Controllers
{
    /// <summary>
    /// Override of the ApiController class to handle database context and to provide the ServiceProvider to all api controllers
    /// </summary>
    public class LoanCalculatorApiController: ApiController
    {
        public LoanCalculatorServiceProvider ServiceProvider { get; set; }
        private readonly IDbContext _dbContext;

        public LoanCalculatorApiController()
        {
            _dbContext = new LoanCalculatorDbContext();
            ServiceProvider = new LoanCalculatorServiceProvider(_dbContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}