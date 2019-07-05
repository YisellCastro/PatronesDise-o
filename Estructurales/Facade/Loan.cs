using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <resumen> 

    /// La clase 'Subsistema ClassC'

    /// </resumen> 

    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Verificar préstamos para " + c.Name);
            return true;
        }
    }
}
