using Dependency.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency.Controllers
{
    [Route("api/[controller]")]
    public class SalaryController : Controller
    {
        private ISalaryCalculator _calculator;


        public SalaryController(ISalaryCalculator injectedCalculator)

        {

            _calculator = injectedCalculator;

        }


        //[HttpGet("{yearlyAmount}")]

        //public Double Get(Double yearlyAmount)

        //{

        //    Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);

        //    return calculatedSalary;

        //}

        [HttpGet("{yearlyAmount}")]

        public Double GetQuartely(Double yearlyAmount)

        {

            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);

            return calculatedSalary;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
