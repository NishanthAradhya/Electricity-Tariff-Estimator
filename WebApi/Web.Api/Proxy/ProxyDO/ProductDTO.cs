using System;
using System.Collections.Generic;
namespace Proxy
{
    public class ProductDTO
    {
        public string Name { get; set; } = "";
        public int Type { get; set; }
        public int BaseCost { get; set; }
        public int AdditionalKwhCost { get; set; }
        public int IncludedKwh { get; set; } = 0;
    }
}
