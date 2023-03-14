using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProductBO
    {
        public string Name { get; set; } = "";
        public int Type { get; set; }
        public int BaseCost { get; set; }
        public int AdditionalKwhCost { get; set; }
        public int IncludedKwh { get; set; } = 0;
    }
}
