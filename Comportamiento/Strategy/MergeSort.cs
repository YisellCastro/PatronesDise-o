﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <resumen> 

    /// Una clase 'ConcreteStrategy'

    /// </resumen> 

    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented

            Console.WriteLine("Lista MergeSorted ");
        }
    }
}
