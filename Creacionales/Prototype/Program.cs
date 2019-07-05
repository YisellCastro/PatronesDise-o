using System;
using System.Collections.Generic;

namespace Prototype
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de prototipo.

    /// </resumen> 

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();

            // Inicializar con colores estándar

            colormanager["rojo"] = new Color(255, 0, 0);
            colormanager["verde"] = new Color(0, 255, 0);
            colormanager["azul"] = new Color(0, 0, 255);

            // El usuario añade colores personalizados.

            colormanager["enojado"] = new Color(255, 54, 0);
            colormanager["paz"] = new Color(128, 211, 128);
            colormanager["llama"] = new Color(211, 34, 20);

            // Clones de usuario seleccionados colores

            Color color1 = colormanager["rojo"].Clone() as Color;
            Color color2 = colormanager["paz"].Clone() as Color;
            Color color3 = colormanager["llama"].Clone() as Color;

            // Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La clase abstracta 'Prototipo'

    /// </resumen> 

    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
