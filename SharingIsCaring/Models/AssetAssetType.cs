using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetAssetType
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }

        public override string ToString()
        {
            return AssetType.ToString();
        }
    }
}
