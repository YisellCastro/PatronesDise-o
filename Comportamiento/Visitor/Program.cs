using System;
using System.Collections.Generic;

namespace Visitor
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de visitantes.

    /// </resumen> 

    class program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen> 

        static void Main(string [] args)
        {
            // Configurar colección de empleados

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Los empleados son 'visitados'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La interfaz 'Visitante'

    /// </resumen> 

    interface IVisitor
    {
        void Visit(Element element);
    }
}