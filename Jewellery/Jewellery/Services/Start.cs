using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Services
{
    internal class Start : Interfaces.IStart, Interfaces.IBeginInfo, Interfaces.IEndInfo
    {
        public void BeginInfo()
        {
            Console.WriteLine("how many pieces of jewellery are there in the shop ?");
        }

        public void Run()
        {
            StartArray startArray = new StartArray();
            BeginFilling beginFilling = new BeginFilling();
            Counting counting = new Counting();
            Sorting sorting = new Sorting();

            beginFilling.ArrayFilling(startArray.BeginArray);
            counting.CostCalculation(startArray.BeginArray);

            Console.WriteLine("Enter search string");
            string line = Console.ReadLine();
            SearchExtension.Search(startArray.BeginArray, line);

            sorting.SortRequest(startArray.BeginArray);
        }

        public void EndInfo()
        {
            Console.WriteLine("End of program");
        }
    }
}
