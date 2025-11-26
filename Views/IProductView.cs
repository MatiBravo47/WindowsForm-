using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Views

{
    interface IProductView
    {
        // Events
        event EventHandler AddRequested;
        event EventHandler EditRequested;
        event EventHandler DeleteRequested;
        event EventHandler SaveRequested;
        event EventHandler CancelRequested;
        event EventHandler SearchRequested;

        // Feedback
        Guid SelectedId();
        void Info(string msg);
        void Error(string msg);

        //Datos
        void EnterEditMode(bool isNew);
        void ExitEditMode();
        void BindProducts(IEnumerable<Product> products);
        void LoadEditor(Product product);
        Product ReadEditor();
        string searchText();
    }
}
