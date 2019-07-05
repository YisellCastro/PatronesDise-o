using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de método de fábrica.

    /// </resumen> 

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen> 

        static void Main(string[] args)
        {
            // Nota: los constructores llaman Método de fábrica

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Mostrar las páginas del documento

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La clase abstracta 'Producto'

    /// </resumen> 

    abstract class Page
    {
    }
}