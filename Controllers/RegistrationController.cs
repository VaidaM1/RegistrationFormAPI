using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly RegistrationService _registrationService;

        public RegistrationController(RegistrationService registrationService)
        {
            _registrationService = registrationService;
        }


        [HttpGet]
        public async Task<ActionResult<List<SelectedValue>>> GetAll()
        {
            return Ok(await _registrationService.GetAllAsync());
        }


    }
    
}
