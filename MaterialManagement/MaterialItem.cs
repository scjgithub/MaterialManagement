using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement
{
    class MaterialItem
    {
        public string itemString = "";
        public string barcode = "";
        public string specification = "";

        public override string ToString()
        {
            return itemString;
        }
    }
}
