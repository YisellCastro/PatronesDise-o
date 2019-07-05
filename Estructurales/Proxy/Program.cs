using System;

namespace Proxy
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño proxy.

    /// </resumen> 

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            // Crear proxy matemático

            MathProxy proxy = new MathProxy();

            // Haz las matematicas

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            // Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La 'interfaz de sujeto

    /// </resumen>

    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}