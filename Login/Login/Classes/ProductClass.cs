using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productMaterials { get; set; }
        public int productQuantity { get; set; }

        public Product(int id, string name, string materials, int quantity)
        {
            productID = id;
            productName = name;
            productMaterials = materials;
            productQuantity = quantity;
        }
    }
}
