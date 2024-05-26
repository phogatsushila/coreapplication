using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreapplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        [HttpGet]
        public IActionResult Getallstudent()
        {
            string[] student = new string[] { "student1", "student2", "student3", "student4" };
            return Ok(student);

        }
    }
}
