using Microsoft.AspNetCore.Mvc;

namespace APITutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase{

        [HttpGet]
        public string Get(){
            return "Hello from .NET Core!";
        }
    }
}