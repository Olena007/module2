using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class BeginFilling
    {
        public void ArrayFilling(string[] arr)
        {
            StartInfo startInfo = new StartInfo();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = startInfo.StartInformation();
            }
        }
    }
}
