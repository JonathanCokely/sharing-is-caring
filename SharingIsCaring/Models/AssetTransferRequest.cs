using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetTransferRequest
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int TransferRequestId { get; set; }
        public TransferRequest TransferRequest { get; set; }

        public override string ToString()
        {
            return TransferRequest.ToString();
        }
    }
}
