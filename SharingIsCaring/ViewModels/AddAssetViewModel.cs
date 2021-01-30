using Microsoft.AspNetCore.Mvc.Rendering;
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
        public List<SelectListItem> BrandList {get; set; } 
        public List<SelectListItem> AssetTypeList { get; set; }


        public string SerialNumber { get; set; }

        public AddAssetViewModel(List<Brand> brands, List<AssetType> assetTypes)
        {
            BrandList = new List<SelectListItem>();
            AssetTypeList = new List<SelectListItem>();

        }
        public AddAssetViewModel() {}
    }   
}
