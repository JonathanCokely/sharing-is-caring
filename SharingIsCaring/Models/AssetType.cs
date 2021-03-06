﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A description is required.")]
        public string TypeDescription { get; set; }

        public AssetType(string typedescription)
        {
            TypeDescription = typedescription;
        }

        public AssetType()
        {

        }

        public override string ToString()
        {
            return TypeDescription;
        }
    }
}
