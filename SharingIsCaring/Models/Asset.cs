using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public Brand BrandName { get; set; }
        public string Description { get; set; }
        public AssetType ItemType { get; set; }
        public string SerialNumber { get; set; }


        public Asset(Brand brandname, string description, AssetType itemtype, string serialnumber)
        {
            BrandName = brandname;
            Description = description;
            ItemType = itemtype;
            SerialNumber = serialnumber;
        }

        public Asset()
        {

        }
    }
}
