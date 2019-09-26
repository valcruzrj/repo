using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private IRateAppService _rateAppService { get; set; }

        public RateController(IRateAppService rateAppService)
        {
            _rateAppService = rateAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]RateDto rateDto)
        {
            if (_rateAppService.Create(rateDto))
                return Ok(rateDto);
            else
                return BadRequest();
        }
    }
}