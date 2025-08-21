using Calculator.Models;
using Microsoft.AspNetCore.Mvc;


namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Calculate(double Number1, double Number2, string Operation)
        {
            var model = new CalculatorModel
            {
                Number1 = Number1,
                Number2 = Number2,
                Operation = Operation
            };

            switch (Operation)
            {
                case "+":
                    model.Result = Number1 + Number2;
                    break;
                case "-":
                    model.Result = Number1 - Number2;
                    break;
                case "*":
                    model.Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 == 0)
                        model.ErrorMessage = "Cannot divide by zero!";
                    else
                        model.Result = Number1 / Number2;
                    break;
                default:
                    model.ErrorMessage = "Please select a valid operation!";
                    break;
            }

            return View("Index", model);
        }
    }
}