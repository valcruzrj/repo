using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private IParkingAppService _parkingAppService { get; set; }

        public ParkingController(IParkingAppService parkingAppService)
        {
            _parkingAppService = parkingAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]ParkingDto parkingDto)
        {
            if (_parkingAppService.Create(parkingDto))
                return Ok(parkingDto);
            else
                return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_parkingAppService.GetAll());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_parkingAppService.GetById(id));
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper(int id)
        {
            return Ok(_parkingAppService.GetAllWithDapper());
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_parkingAppService.Delete(id))
                return Ok();
            else
                return BadRequest();
        }
    }
}