using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <resumen> 

    /// Una clase 'ConcreteProduct'

    /// </resumen>

    class BibliographyPage : Page
    {
    }

    /// <resumen> 

    /// La clase abstracta 'Creador'

    /// </resumen>

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // El constructor llama al método de fábrica abstracto

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Método de fábrica

        public abstract void CreatePages();
    }
}
