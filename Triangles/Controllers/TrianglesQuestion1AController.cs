using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Triangles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrianglesQuestion1AController : ControllerBase
    {
        // GET api/TrianglesQuestion1A
        [HttpGet]
        public ActionResult<string> Get(string row, string col)
        {
            return Triangles.Question1A(row, col);
            
        }


 
    }
}
