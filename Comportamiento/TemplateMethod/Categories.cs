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

    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "seleccione Nombre de Categoría de Categorías";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categorías");
        }

        public override void Process()
        {
            Console.WriteLine("Categorías ---- ");

            DataTable dataTable = dataSet.Tables["Categorías"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["Nombre de Categoría"]);
            }
            Console.WriteLine();
        }
    }
}
