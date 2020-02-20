using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Triangles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrianglesQuestion1BController : ControllerBase
    {
        // GET api/TrianglesQuestion1B
        [HttpGet]
        public ActionResult<string> Get(string c1x, string c1y, string c2x, string c2y, string c3x, string c3y)
        {
            return Triangles.Question1B(c1x, c1y, c2x, c2y, c3x, c3y);
            
            
        }


    }
}
