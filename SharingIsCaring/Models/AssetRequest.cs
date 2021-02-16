using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetRequest
    {
        public int Id { get; set; }
        public Asset Asset { get; set; }
        public int AssetId { get; set; }
        public string BorrowerId { get; set; }
        [Required(ErrorMessage ="Must enter a request subject")]
        public string Subject { get; set; }
        public string Body { get; set; } 
        [Required(ErrorMessage = "Must enter a desired checkout date")]
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage = "Must enter a projected return date")]
        public DateTime FromDate { get; set; }

        public override string ToString()
        {
            return Subject;
        }
    }
}
