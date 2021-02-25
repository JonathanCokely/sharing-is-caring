using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class TransferAssetViewModel
    {
        public int TransferRequestId { get; set; }
        public int AssetId { get; set; }
        public string ExpectedReturnDateTime { get; set; }
        public string BorrowerId { get; set; }
        public string OwnerId { get; set; }
    }
}
