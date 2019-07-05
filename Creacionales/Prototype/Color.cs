using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <resumen> 

    /// La clase 'ConcretePrototype'

    /// </resumen> 

    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Crear una copia superficial

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "Clonación de color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
