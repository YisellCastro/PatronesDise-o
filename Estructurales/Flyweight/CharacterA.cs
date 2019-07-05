﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <resumen> 

    /// Una clase 'ConcreteFlyweight'

    /// </resumen> 

    class CharacterA : Character
    {
        // Constructor

        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (tamaño de punto " + this.pointSize + ")");
        }
    }
}
