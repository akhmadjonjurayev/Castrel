using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocelot.Client.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(new { name = "Shakhrizoda Jurayeva" });
        }
    }
}
