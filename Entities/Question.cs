using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public List<DropDownOption> DropDownOptions { get; set; }
    }
}
