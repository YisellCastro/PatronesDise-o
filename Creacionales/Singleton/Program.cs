using System;
using System.Collections.Generic;
using System.Threading;

namespace Singleton
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de Singleton.

    /// </resumen> 

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // ¿Misma instancia?

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Misma instancia\n");
            }

            // Peticiones del servidor del balance de carga 15

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Enviar solicitud a: " + server);
            }

            // Espera al usuario

            Console.ReadKey();
        }
    }
}