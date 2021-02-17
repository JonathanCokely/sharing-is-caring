using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.ViewModels
{
    public class RequestAssetViewModel
    {
        [Required(ErrorMessage = "An Id is required to request an asset")]
        public int AssetId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        [Required(ErrorMessage = "Must enter a desired checkout date")]
        public string FromDate { get; set; }
        [Required(ErrorMessage = "Must enter a projected return date")]
        public string ToDate { get; set; }
        public string BorrowerId { get; set; }
        public string OwnerId { get; set; }
    }
}
