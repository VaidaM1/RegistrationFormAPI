using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Entities
{
    public class SelectedValue
    {
        public int RegistrationId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int DropDownOptionId { get; set; }
        public DropDownOption DropDownOption { get; set; }
    }
}
