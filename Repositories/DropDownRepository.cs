using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{
    public class DropDownRepository
    {
        private readonly DataContext _dataContext;

        public DropDownRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<DropDownOption>> GetAllDropDownsAsync()
        {
            return await _dataContext.DropDownOptions.ToListAsync();
        }


    }
}
