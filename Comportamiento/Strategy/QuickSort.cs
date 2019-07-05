using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <resumen> 

    /// Una clase 'ConcreteStrategy'

    /// </resumen>

    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // El valor predeterminado es Quicksort

            Console.WriteLine("Lista QuickSorted ");
        }
    }
}
