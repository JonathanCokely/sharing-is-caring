using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class TransferRequest
    {
        public int Id { get; set; }
        public Asset Asset { get; set; }
        public int AssetId { get; set; }
        public DateTime TransferDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public string BorrowerId { get; set; }
        public string OwnerId { get; set; }
    }
}
