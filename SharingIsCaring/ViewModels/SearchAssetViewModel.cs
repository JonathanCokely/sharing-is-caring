using Microsoft.AspNetCore.Mvc.Rendering;
using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class SearchAssetViewModel
    {
        public Brand BrandName { get; set; }
        public int BrandId { get; set; }
        public AssetType ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public List<SelectListItem> BrandList { get; set; }
        public List<SelectListItem> AssetTypeList { get; set; }
        public List<Asset> AssetList { get; set; }
        public string SearchBrand { get; set; }

        public SearchAssetViewModel(List<Brand> brands, List<AssetType> assetTypes, List<Asset> assets)
        {
            BrandList = new List<SelectListItem>();
            AssetTypeList = new List<SelectListItem>();
            AssetList = assets;


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

        public SearchAssetViewModel() { }
    }
}
