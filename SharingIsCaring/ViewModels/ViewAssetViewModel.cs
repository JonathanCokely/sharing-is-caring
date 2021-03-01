using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class ViewAssetViewModel
    {
        public Asset Asset { get; set; }
        public AssetType AssetType { get; set; }
        public Brand Brand { get; set; }
        public ViewAssetViewModel(Asset asset, AssetType assetType, Brand brand)
        {
            Asset = asset;
            AssetType = assetType;
            Brand = brand;
        }

        public ViewAssetViewModel() { }
    }
}
