using System;
using System.Data;
using System.Data.OleDb;

namespace TemplateMethod
{
    /// <resumen> 

    /// clase de inicio MainApp para el mundo real

    /// Patrón de diseño de plantillas.

    /// </resumen>

    class Program
    {
        /// <resumen> 

        /// Punto de entrada en la aplicación de consola.

        /// </resumen>

        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Espera al usuario

            Console.ReadKey();
        }
    }

    /// <resumen> 

    /// La clase abstracta 'AbstractClass'

    /// </resumen> 

    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Asegúrate de que mdb está disponible para la aplicación

            connectionString =
              "provider=Microsoft.JET.OLEDB.4.0; " +
              "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // El 'Método de plantilla' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
