using System;
using System.Collections.Generic;

namespace Flyweight
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de peso mosca.

    /// </resumen>

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen> 

        static void Main(string[] args)
        {
            // Construir un documento con texto

            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // estado extrínseco

            int pointSize = 10;

            // Para cada personaje usa un objeto de peso mosca

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Espera al usuario

            Console.ReadKey();
        }
    }
}