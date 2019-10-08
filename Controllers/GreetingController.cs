using Microsoft.AspNetCore.Mvc;

namespace GreetingController.Controllers{
    [APIController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase{

        [HttpGet]
        public string Get(){
            return "Hello from .NET Core!";
        }
    }
}