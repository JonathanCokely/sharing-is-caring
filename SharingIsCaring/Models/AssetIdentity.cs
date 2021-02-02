using SharingIsCaring.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetIdentity
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int AspNetUserId { get; set; }
        public SharingIsCaringUser AspNetUser { get; set; }
    }
}
