using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
            _logger= logger;
            
        }

        [HttpGet("/api/people")]
        public IActionResult GetPeople() {
            _logger.Log("GetPeople api call sucess");
            _logger.Log("Get");
            return Ok( PersonOpertaions.GetPeople());
               
        }
        [HttpPost("api/create")]
        public IActionResult CreatePerson([FromBody]Person p) {
            PersonOpertaions.CreateNew(p);
            _logger.Log("CreatePerson api call sucess");
            return Created($"Created person with adahar{p.Aadhar}",p);
        }

        [HttpPut("/api/update/{pAadhar}")]
        public IActionResult UpdatePerson([FromRoute]string pAadhar,[FromBody]Person updaterPerson) {
            try
            {
                PersonOpertaions.Update(pAadhar, updaterPerson);
                _logger.Log("Update Person api call sucess");
                return Ok("updated successfully");

            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return  NotFound(ex.Message);
            }
           
        }

        [HttpDelete("/api/delete")]
        //https://localhost:7012?key=value
        public IActionResult DeletePerson([FromQuery]string pAadhar)
        {
            try
            {
                PersonOpertaions.Delete(pAadhar);
                _logger.Log("deleteperson api call sucess");
                return Ok("Deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                return NotFound(ex.Message);
            }
           
        }
    
    }
}
