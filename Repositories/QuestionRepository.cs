using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Data;
using RegistrationFormAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Repositories
{
    public class QuestionRepository
        {
            private readonly DataContext _dataContext;

        public QuestionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


         public async Task<List<Question>> GetAllQuestionsAsync()
         {
                return await _dataContext.Questions.ToListAsync();
         }




    }
}
