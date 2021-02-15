using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetRequest
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public string OwnerId { get; set; }
        public string BorrowerId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; } 
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }

    }
}
