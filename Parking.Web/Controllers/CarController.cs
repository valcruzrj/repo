using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarAppService _carAppService { get; set; }

        public CarController(ICarAppService carAppService)
        {
            _carAppService = carAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]CarDto carDto)
        {
            if (_carAppService.Create(carDto))
                return Ok(carDto);
            else
                return BadRequest();
        }
    }
}