using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class AddBrandViewModel
    {
        [Required(ErrorMessage = "A name is required.")]
        public string Name { get; set; }
    }
}
