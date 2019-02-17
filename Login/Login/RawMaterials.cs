using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManagement
{
    class RawMaterials
    {
        private string material { get; set; }
        private double? unitCost { get; set; }

        public RawMaterials()
        {
            material = "";
            unitCost = null;
        }

        public RawMaterials(string rMaterial, double? uCost)
        {
            rMaterial = material;
            uCost = unitCost;
        }
    }
}
