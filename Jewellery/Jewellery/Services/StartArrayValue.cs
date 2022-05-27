using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class StartArrayValue
    {
        public StartArrayValue() { }

        public static int StartArrayIndex()
        {
            string num = Console.ReadLine();
            int index = Convert.ToInt32(num);

            return index;
        }
    }
}
