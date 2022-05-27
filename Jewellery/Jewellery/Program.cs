using System;

namespace Jewellery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Services.Common common = new Services.Common();

            common.GetRun(new Services.Start());
        }
    }
}
