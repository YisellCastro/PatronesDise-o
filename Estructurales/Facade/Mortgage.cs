using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <resumen> 

    /// La clase 'Fachada'

    /// </resumen> 

  class Mortgage

  {
    private Bank _bank = new Bank();
    private Loan _loan = new Loan();
    private Credit _credit = new Credit();
 
    public bool IsEligible(Customer cust, int amount)
    {
        Console.WriteLine("{0} se aplica al  {1:C} préstamo\n",
        cust.Name, amount);
 
      bool eligible = true;

      // Comprobar la solvencia del solicitante

      if (!_bank.HasSufficientSavings(cust, amount))
      {
        eligible = false;
      }
      else if (!_loan.HasNoBadLoans(cust))
      {
        eligible = false;
      }
      else if (!_credit.HasGoodCredit(cust))
      {
        eligible = false;
      }
 
      return eligible;
    }
  }
}