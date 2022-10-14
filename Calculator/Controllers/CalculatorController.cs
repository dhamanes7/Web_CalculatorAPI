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
        public double Addition(double num1,double num2) //api for adding 2 numbers
        {
            return CalculatorFunc.Calculator.Add(num1, num2);
        }

        [HttpGet]
        public double Subtraction(double num1, double num2) // api for subtraction of 2 numbers
        {
            return CalculatorFunc.Calculator.Subtract(num1, num2);
        }


        [HttpGet]
        public double Multiplication(double num1, double num2) // api for multiplication of 2 numbers
        {
            return CalculatorFunc.Calculator.Multiply(num1, num2);
        }

        [HttpGet]
        public double Division(double num1, double num2) // api for division of 2 numbers
        {
            try
            {
                result=CalculatorFunc.Calculator.Division(num1, num2); 
            }
            catch(DivideByZeroException)
            {
                Response.StatusCode = 400; //if number 2 is zero code will be set to 400
            }
            return result;
        }
    }

}

