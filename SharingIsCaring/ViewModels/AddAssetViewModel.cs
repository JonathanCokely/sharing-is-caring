using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class AddAssetViewModel
    {
        public Brand BrandName { get; set; }

        [Required(ErrorMessage = "Must enter a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Must select an Item Type")]
        public AssetType ItemType { get; set; }

        public string SerialNumber { get; set; }

    }
}
