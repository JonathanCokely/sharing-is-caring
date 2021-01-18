using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class User
    {
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }


        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public User()
        {

        }
    }
}
