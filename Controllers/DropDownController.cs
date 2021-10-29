using Microsoft.AspNetCore.Mvc;
using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropDownController : ControllerBase
    {
        private readonly DropDownService _dropDownService;

        public DropDownController(DropDownService dropDownService)
        {
            _dropDownService = dropDownService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DropDownOption>>> GetAllDropDowns()
        {
            return Ok(await _dropDownService.GetAllDropDownsAsync());
        }
    }

}
