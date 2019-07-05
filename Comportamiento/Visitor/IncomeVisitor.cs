using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <resumen> 

    /// Una clase 'ConcreteVisitor'

    /// </resumen> 

    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Proporcionar un aumento salarial del 10%

            employee.Income *= 1.10;
            Console.WriteLine("{0} {1} Los nuevos ingresos son: {2:C}",
              employee.GetType().Name, employee.Name,
              employee.Income);
        }
    }
}
