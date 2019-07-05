using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <resumen> 

    /// Una clase 'ConcreteClass'

    /// </resumen> 
    class Products : DataAccessObject

  {
      public override void Select()
      {
          string sql = "seleccione Nombre de Producto de Productos";
          OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
            sql, connectionString);

          dataSet = new DataSet();
          dataAdapter.Fill(dataSet, "Productos");
      }

      public override void Process()
      {
          Console.WriteLine("Productos ---- ");
          DataTable dataTable = dataSet.Tables["Productos"];
          foreach (DataRow row in dataTable.Rows)
          {
              Console.WriteLine(row["Nombre de Producto"]);
          }
          Console.WriteLine();
    }
  }
}
