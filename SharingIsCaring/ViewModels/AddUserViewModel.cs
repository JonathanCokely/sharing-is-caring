using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Must enter a Username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Must enter an email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
