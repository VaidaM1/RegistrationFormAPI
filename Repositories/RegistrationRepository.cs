using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{
    public class RegistrationRepository
    {
        private readonly DataContext _dataContext;

        public RegistrationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<SelectedValue>> GetAllAsync()
        {
            return await _dataContext.SelectedValues.ToListAsync();
        }




        //public SelectedValue GetById()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
