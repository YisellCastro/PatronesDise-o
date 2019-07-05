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
    class VacationVisitor : IVisitor

  {
    public void Visit(Element element)
    {
      Employee employee = element as Employee;

      // Proporcionar 3 días adicionales de vacaciones

      employee.VacationDays += 3;
      Console.WriteLine("{0} {1} días de vacaciones nuevos: {2}",
        employee.GetType().Name, employee.Name,
        employee.VacationDays);
    }
  }

    /// <resumen> 

    /// La clase abstracta 'Elemento'

    /// </resumen> 

  abstract class Element

  {
    public abstract void Accept(IVisitor visitor);
  }
}
