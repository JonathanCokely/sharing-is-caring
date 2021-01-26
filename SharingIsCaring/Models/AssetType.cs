using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class AssetType
    {
        public int Id { get; set; }
        public string TypeDescription { get; set; }

        public AssetType(string typedescription)
        {
            TypeDescription = typedescription;
        }

        public override string ToString()
        {
            return TypeDescription;
        }
    }
}
