using Microsoft.AspNetCore.Mvc;
using Calc.Models;
using Calc.Services;

namespace Calc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly IHistoryService historyService;
        public CalcController (IHistoryService ihistoryservice)
        {
            historyService = ihistoryservice;
        }

        [HttpGet("Add/{a}/{b}")]
        public ActionResult<double> Add(double a, double b)
        {
            var result = a + b;
            var calculation = new Calculation
            {
                a = a,
                b = b,
                result = result,
                operation = "+"
            };
            historyService.AddToHistory(calculation);
            return calculation.result;
        }

        [HttpGet("Substract/{a}/{b}")]
        public ActionResult<double> Substract(double a, double b)
        {
            var result = a - b;
            var calculation = new Calculation
            {
                a = a,
                b = b,
                result = result,
                operation = "-"
            };
            historyService.AddToHistory(calculation);
            return calculation.result;
        }

        [HttpGet("Multiply/{a}/{b}")]
        public ActionResult<double> Multiply(double a, double b)
        {
            var result = a * b;
            var calculation = new Calculation
            {
                a = a,
                b = b,
                result = result,
                operation = "x"
            };
            historyService.AddToHistory(calculation);
            return calculation.result;
        }

        [HttpGet("Divide/{a}/{b}")]
        public ActionResult<double> Divide(double a, double b)
        {
            var result = a / b;
            var calculation = new Calculation
            {
                a = a,
                b = b,
                result = result,
                operation = "/"
            };
            historyService.AddToHistory(calculation);
            return calculation.result;
        }

        [HttpGet("ShowHistory")]
        public List<string> GetHistory()
        {
            return historyService.GetHistory();            
        }





    }
}
