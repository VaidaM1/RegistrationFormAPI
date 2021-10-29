using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Services
{
    public class RegistrationService
    {
        private RegistrationRepository _registrationRepository;

        public RegistrationService(RegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public async Task<List<SelectedValue>> GetAllAsync()
        {
            return await _registrationRepository.GetAllAsync();
        }




    }
}
