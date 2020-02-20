using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Triangles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrianglesQuestion1ATestsController : ControllerBase
    {
        // GET api/TrianglesQuestion1ATests
        [HttpGet]
        public ActionResult<string> Get()
        {
            String displayResult = String.Empty;
            string result = String.Empty;

            //A1
            result = Triangles.Question1A("A", "1");
            if (result == "(0,10) (0,0) (10,10)")
                displayResult += String.Format("Test with A 1 : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with A 1 : Result = {0} : TEST NOK\n", result);

            

            //F12
            result = Triangles.Question1A("F", "12");
            if (result == "(60,50) (60,60) (50,50)")
                displayResult += String.Format("Test with F 12 : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with F 12 : Result = {0} : TEST NOK\n", result);

            //C5
            result = Triangles.Question1A("C", "5");
            if (result == "(20,30) (20,20) (30,30)")
                displayResult += String.Format("Test with C 5 : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with C 5 : Result = {0} : TEST NOK\n", result);



            //Error 1
            result = Triangles.Question1A("Z", "5");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with Z 5 : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with Z 5 : Result = {0} : TEST NOK\n", result);

            //Error 2
            result = Triangles.Question1A(" ", " ");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with \"\" \"\" : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with \"\" \"\" : Result = {0} : TEST NOK\n", result);

            //Error 3
            result = Triangles.Question1A(null, null);
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with null null : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with null null : Result = {0} : TEST NOK\n", result);

            //Error 4
            result = Triangles.Question1A("C", "-1");
            if (result == Triangles.ErrorInvalidInput)
                displayResult += String.Format("Test with C -1 : Result = {0} : TEST OK\n", result);
            else
                displayResult += String.Format("Test with C -1 : Result = {0} : TEST NOK\n", result);


            return displayResult;
        }


 
    }
}
