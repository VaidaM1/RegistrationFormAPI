using RegistrationFormAPI.Entities;
using RegistrationFormAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Services
{
    public class QuestionService
    {
        private QuestionRepository _questionRepository;


        public QuestionService(QuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<List<Question>> GetAllQuestionsAsync()
        {
            return await _questionRepository.GetAllQuestionsAsync();
        }
       




    }
}
