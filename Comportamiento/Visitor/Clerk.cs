﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // Tres tipos de empleados
    class Clerk : Employee
    {
        // Constructor

        public Clerk()
            : base("Hank", 25000.0, 14)
        {
        }
    }
}
