using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp_Day2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
        [HttpGet]
        public string GetEmployee()
        {
            return "Hi this is me";
        }
    }
}
