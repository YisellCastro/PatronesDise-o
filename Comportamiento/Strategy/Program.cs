using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de Diseño de Estrategia.

    /// </resumen>

    class program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            // Dos contextos siguiendo diferentes estrategias.

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            /// Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La clase abstracta de 'Estrategia'

    /// </resumen>

    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
