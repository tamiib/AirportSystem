using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexController : ControllerBase
    {
        private readonly SexRepository _sexRepository;
        public SexController(SexRepository sexRepository)
        {
            _sexRepository = sexRepository;
        }

        [HttpGet]
        public IActionResult GetSexes()
        {
            try
            {
                return Ok(_sexRepository.GetSexes());
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
