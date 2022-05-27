using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class StartInfo
    {
        public string StartInformation()
        {
            Console.WriteLine(" ");

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Console.Write("Price: ");
            string price = Console.ReadLine();

            Models.BaseJewelry baseJewelry = new Models.BaseJewelry(type, color, Convert.ToInt32(price));

            string str = type + " " + color + " " + price;

            return str;
        }
    }
}
