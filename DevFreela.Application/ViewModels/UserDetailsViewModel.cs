using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
