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

    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort (); no se ha implementado

            Console.WriteLine("Lista ShellSorted ");
        }
    }
}
