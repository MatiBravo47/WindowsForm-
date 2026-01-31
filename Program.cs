using System;
using System.Windows.Forms;
using Views;
using Model;
using Controllers;

namespace WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear repositorios con persistencia
            IProductRepository productRepo = new GenericProductRepository();
            IClientRepository clientRepo = new GenericClientRepository();

            // Mostrar menú principal
            Application.Run(new MainForm(productRepo, clientRepo));
        }
    }
}
