using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        private IAgreementAppService _agremmentAppService { get; set; }

        public AgreementController(IAgreementAppService agremmentAppService)
        {
            _agremmentAppService = agremmentAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]AgreementDto agremmentDto)
        {
            if (_agremmentAppService.Create(agremmentDto))
                return Ok(agremmentDto);
            else
                return BadRequest();
        }
    }
}