using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <resumen> 

    /// La clase 'Subsistema ClassA'

    /// </resumen>

    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Verificar banco para " + c.Name);
            return true;
        }
    }
}
