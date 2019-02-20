using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManagement
{
    class RawMaterials
    {
        public string material { get; set; }
        
        public RawMaterials()
        {
            material = "";
        }

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
