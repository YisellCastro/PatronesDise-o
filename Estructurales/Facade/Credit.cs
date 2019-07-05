using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <resumen> 

    /// La clase 'Subsistema ClassB'

    /// </resumen> 

    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Verificar crédito para " + c.Name);
            return true;
        }
    }
}
