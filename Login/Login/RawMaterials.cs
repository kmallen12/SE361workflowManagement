using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    /// LAST EDITED BY: Kristen 
    /// DATE: 2/25/2019
    /// DESCRIPTION: Class to manage Raw Materials. 
    public class RawMaterials
    {
        public string material { get; set; }

        public RawMaterials(string rMaterial)
        {
            material = rMaterial;
        }
        
        //override ToString
        public override string ToString()
        {
            return material;
        }
    }
}
