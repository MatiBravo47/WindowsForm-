using System;
using System.Windows.Forms;
using Views;
using Model;
using Controllers;

namespace WinForms
{
    static class Program
    {
        /* 
        Este atributo indica que la aplicación utilizará un modelo de un solo hilo (STA),
        necesario para que Windows Forms funcione correctamente y para soportar características
        como cuadros de diálogo, portapapeles y manejo seguro de la UI.
        */
        [STAThread]
        static void Main()
        {
            // Habilita los estilos visuales modernos de Windows para los controles.
            Application.EnableVisualStyles();
            // Define el motor de renderizado de texto.
            // false = usa GDI+, recomendado para la mayoría de las aplicaciones WinForms.
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            // FORMA 1 de inicializacion: Sin patrón MVP (formulario simple)
            // Application.Run(new ProductForm());
            
            //Crear dependencias
            IProductRepository repo = new InMemoryProductRepository();
            
            // FORMA 2: Con patrón MVP (inyección de dependencias)
            //Crear el formulario UNA SOLA VEZ
            
            ProductForm form = new ProductForm();
            IProductView view = form;
            

            //Crear y configurar el controlador
            var controller = new ProductController(repo, view);
            controller.Init();

            //Iniciar la aplicación con el formulario configurado
            Application.Run((Form)view);
        }
    }
}
