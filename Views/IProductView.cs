using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Views

{
    //Se implementa en ProductForm.cs 
    interface IProductView
    {
        // Events: avisa que el usuario lo pidió
        event EventHandler AddRequested;
        event EventHandler EditRequested;
        event EventHandler DeleteRequested;
        event EventHandler SaveRequested;
        event EventHandler CancelRequested;
        event EventHandler SearchRequested;

        // Feedback(respuesta al usuario)
        Guid SelectedId();
        //Info: Muestra mensajes informativos
        void Info(string msg);
        //Muestra errores
        void Error(string msg);
        bool Confirm(string msg);

        //Datos(interacción con la UI)
        void EnterEditMode(bool isNew);
        void ExitEditMode();
        void BindProducts(IEnumerable<Product> products);
        void LoadEditor(Product product);
        Product ReadEditor();
        string searchText();
    }
}
