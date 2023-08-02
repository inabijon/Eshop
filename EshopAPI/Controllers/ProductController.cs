using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EshopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController: ControllerBase 
    {

        [HttpGet]
        public IActionResult Get() { 
           return Ok("Hello World");
        }
    }
    
}
