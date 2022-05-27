using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models
{
    internal class BaseJewelry
    {
        public string Type { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public BaseJewelry() { }

        public BaseJewelry(string type, string color, int ptice)
        {
            this.Type = type;
            this.Color = color;
            this.Price = ptice;
        }
    }
}
