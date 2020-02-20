using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Triangles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrianglesQuestion1BTestsController : ControllerBase
    {
        // GET api/TrianglesQuestion1ATests
        [HttpGet]
        public ActionResult<string> Get()
        {
            String displayResult = String.Empty;
            string result = String.Empty;

            //A1
            result = Triangles.Question1B("0", "10", "0", "0", "10", "10");
            if (result == "Row A - Column 1")
                displayResult += String.Format("Test with (0, 10) (0, 0) (10, 10) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with (0, 10) (0, 0) (10, 10) : Result = {0} : TEST NOK\n", result);

            //F12
            result = Triangles.Question1B("60", "50", "60", "60", "50", "50");
            if (result == "Row F - Column 12")
                displayResult += String.Format("Test with (60, 50) (60, 60) (50, 50) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with (60, 50) (60, 60) (50, 50) : Result = {0} : TEST NOK\n", result);

            //C5
            result = Triangles.Question1B("20", "30", "20", "20", "30", "30");
            if (result == "Row C - Column 5")
                displayResult += String.Format("Test with (20,30) (20,20) (30,30) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with (20,30) (20,20) (30,30) : Result = {0} : TEST NOK\n", result);

            //Error 1
            result = Triangles.Question1B(" ", "30", " ", "20", "30", "30");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with ( ,30) ( ,20) (30,30) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with ( ,30) ( ,20) (30,30) : Result = {0} : TEST NOK\n", result);

            //Error 2
            result = Triangles.Question1B("20", "60", "20", "20", "30", "30");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with (20,60) (20 ,20) (30,30) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with (20 ,60) (20 ,20) (30,30) : Result = {0} : TEST NOK\n", result);

            //Error 3
            result = Triangles.Question1B("0", "10", "10", "10", "0", "0");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with (0, 10) (10, 10) (0, 0) : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with (0, 10) (10, 10) (0, 0) : Result = {0} : TEST NOK\n", result);


            return displayResult;
        }


 
    }
}
