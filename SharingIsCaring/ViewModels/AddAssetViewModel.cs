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
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Must enter a Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Must select an Item Type")]
        public int ItemTypeId { get; set; }
        public List<SelectListItem> BrandList {get; set; } 
        public List<SelectListItem> AssetTypeList { get; set; }
        [Required(ErrorMessage = "Must enter an identifier, or write 'unknown' if none exists")]
        public string SerialNumber { get; set; }

        public AddAssetViewModel(List<Brand> brands, List<AssetType> assetTypes)
        {
            BrandList = new List<SelectListItem>();
            AssetTypeList = new List<SelectListItem>();

            foreach (var brand in brands)
            {
                BrandList.Add(
                    new SelectListItem
                    {
                        Value = brand.Id.ToString(),
                        Text = brand.Name
                    }
                );
            }

            foreach (var assetType in assetTypes)
            {
                AssetTypeList.Add(
                    new SelectListItem
                    {
                        Value = assetType.Id.ToString(),
                        Text = assetType.TypeDescription
                    }
                );
            }
        }

        public AddAssetViewModel() {}
    }   
}
