using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <resumen> 

    /// La clase 'ConcreteElement'

    /// </resumen> 

    class Employee : Element
    {
        private string _name;
        private double _income;
        private int _vacationDays;

        // Constructor

        public Employee(string name, double income,
          int vacationDays)
        {
            this._name = name;
            this._income = income;
            this._vacationDays = vacationDays;
        }

        // Obtiene o establece el nombre

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Obtiene o establece ingresos

        public double Income
        {
            get { return _income; }
            set { _income = value; }
        }

        // Obtiene o establece el número de días de vacaciones

        public int VacationDays
        {
            get { return _vacationDays; }
            set { _vacationDays = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
