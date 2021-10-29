using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Services
{
    public class DropDownService
    {
        private DropDownRepository _dropDownRepository;

        public DropDownService(DropDownRepository dropDownRepository)
        {
            _dropDownRepository = dropDownRepository;
        }

        public async Task<List<DropDownOption>> GetAllDropDownsAsync()
        {
            return await _dropDownRepository.GetAllDropDownsAsync();
        }
    }
}
