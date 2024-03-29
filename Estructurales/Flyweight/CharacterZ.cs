﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // ... C, D, E, etc.


    /// <resumen> 

    /// Una clase 'ConcreteFlyweight'

    /// </resumen> 

  class CharacterZ : Character

  {
    // Constructor

    public CharacterZ()
    {
      this.symbol = 'Z';
      this.height = 100;
      this.width = 100;
      this.ascent = 68;
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
