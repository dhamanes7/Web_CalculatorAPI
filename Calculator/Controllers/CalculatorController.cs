using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorFunc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CalculatorController : Controller
    {
        double result = 0;


        [HttpGet]
        public double Addition(double num1,double num2)
        {
            return CalculatorFunc.Calculator.Add(num1, num2);
        }

        [HttpGet]
        public double Subtraction(double num1, double num2)
        {
            return CalculatorFunc.Calculator.Subtract(num1, num2);
        }
    }

}

