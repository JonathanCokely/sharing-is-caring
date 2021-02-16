using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetAssetRequest
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int AssetRequestId { get; set; }
        public AssetRequest AssetRequest { get; set; }

        public override string ToString()
        {
            return AssetRequest.ToString();
        }
    }
}