using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private IAccessories _accessories;
        public CarController(Car c,IApiLogger logger,IAccessories a)
        {
            _car = c;
            _accessories = a;
            _logger = logger;

            _logger.Log("car controller");
                   
        }
        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            _logger.Log("Driving api called succesfuly");
            return Ok("driving at 100");
        }


    }
}
