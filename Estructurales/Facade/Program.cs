using System;

namespace Facade
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de fachada.

    /// </resumen>

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            // Fachada

            Mortgage mortgage = new Mortgage();

            // Evaluar la elegibilidad de la hipoteca para el cliente

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " ha sido " + (eligible ? "Aprobado" : "Rechazado"));

            // Espera al usuario

            Console.ReadKey();
        }
    }
}