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
        public int BrandId { get; set; }
        public string Description { get; set; }
        public AssetType ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public string SerialNumber { get; set; }
        public string OwnerId { get; set; }
        //public int BorrowerId { get; set; }
        //public bool Availabile { get; set; }



        public Asset(string description, string serialnumber)
        {
            Description = description;
            SerialNumber = serialnumber;
        }

        public Asset(string description)
        {
            Description = description;
        }

        public Asset()
        {

        }
    }
}
