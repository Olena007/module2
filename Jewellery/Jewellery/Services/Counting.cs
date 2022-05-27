using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class Counting
    {
        public int CostCalculation(string[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    string[] arrnew = arr[i].Split(" ");

                    sum = sum + Convert.ToInt32(arrnew[2]);
                }
            }

            Console.Write("Total sum of all products: ");
            Console.Write(sum);

            return sum;
        }
    }
}
