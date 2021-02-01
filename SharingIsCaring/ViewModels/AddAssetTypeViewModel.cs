using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class AddAssetTypeViewModel
    {
        [Required(ErrorMessage = "A description is required.")]
        public string TypeDescription { get; set; }
    }
}
