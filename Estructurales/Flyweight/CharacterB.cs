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

    class CharacterB : Character
    {
        // Constructor

        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
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
