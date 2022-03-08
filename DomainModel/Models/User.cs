using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
     public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserRole userRole { get; set; }
        public bool CurrentRole { get; set; }
        public enum UserRole
        {
            Admin,
            CheckIn,
            Choose
        }

    }
}
