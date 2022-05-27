using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class Sorting 
    {
        public void SortRequest(string[] arr)
        {
            int n = arr.Length;
            string[][] array = new string[n][];

            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i].Split(" ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array[i]);
            }
        }
    }
}
