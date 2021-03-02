using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class TransferAssetViewModel
    {
        public TransferRequest TransferRequest { get; set; }
        public Asset Asset { get; set; }

        public TransferAssetViewModel(TransferRequest theRequest, Asset theAsset)
        {
            TransferRequest = theRequest;
            Asset = theAsset;
        }
        public TransferAssetViewModel() { }
    }
}
