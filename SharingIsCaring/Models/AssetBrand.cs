using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetBrand
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public override string ToString()
        {
            return Brand.ToString();
        }
    }
}
