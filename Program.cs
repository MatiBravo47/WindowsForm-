using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using Domain;
using Controllers;

namespace Clase28_10
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductForm());

            // Composition Root: acá "enchufamos" las piezas
            IProductRepository repo = new InMemoryProductRepository();
            IProductView view = new ProductForm();
            var controller = new ProductController(repo, view);

            controller.Init();
            Application.Run((Form)view);
        }
    }
}
