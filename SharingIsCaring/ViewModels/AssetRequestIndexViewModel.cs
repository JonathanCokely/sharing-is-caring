using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class AssetRequestIndexViewModel
    {
        public List<Asset> AssetList { get; set; }
        public List<AssetRequest> AssetRequestList { get; set; } 

        public AssetRequestIndexViewModel(List<Asset> assets, List<AssetRequest> assetRequests)
        {
            AssetList = assets;
            AssetRequestList = assetRequests;
        }
        public AssetRequestIndexViewModel() { }
    }
}
