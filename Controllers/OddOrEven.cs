//Isaiah Keith Ferguson
//10/25/2022
//Odd or Even End Points
//User will input a number we will decide if it is odd or even.
//Reviewed by: Arely Martinez - Isaiah Went above and beyond because he added data confirmation. Which wasn't mentioned in the assignment, but its a nice little touch. The program did its job of returning a number and determing if its odd or even. As a challange try only having one return. 


using Microsoft.AspNetCore.Mvc;

namespace FergusonIOddOrEvenEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("OddOrEven/{num}")]
    public string OddOrEven(string num)
    {

        double remainder = 0;
        double validnum = 0;
        bool isNumber = true;


        isNumber = double.TryParse(num, out validnum);

        if (!isNumber)
        {
            return "Thats not a number.";
        }
        else
        {
            if (remainder == (validnum % 2))
            {
                return $"Your number {num} is even";
            }
            else
            {
                return $"Your number {num} is odd";
            }
        }
    }

}