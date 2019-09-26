using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerAppService _customerAppService { get; set; }

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]CustomerDto customerDto)
        {
            if (_customerAppService.Create(customerDto))
                return Ok(customerDto);
            else
                return BadRequest();
        }
    }
}