using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        public string Name { get; set; }
    
    
        public Brand(string name)
        {
            Name = name;
        }

        public Brand()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
