using System;
using System.Collections.Generic;
using Model;

namespace Views
{
    /// <summary>
    /// Interfaz para la vista de clientes
    /// </summary>
    interface IClientView
    {
        // Eventos: avisa que el usuario lo pidió
        event EventHandler AddRequested;
        event EventHandler EditRequested;
        event EventHandler DeleteRequested;
        //event EventHandler SaveRequested;
        //event EventHandler CancelRequested;
        event EventHandler SearchRequested;

        // Feedback (respuesta al usuario)
        Guid SelectedId();
        void Info(string msg);
        void Error(string msg);
        bool Confirm(string msg);

        // Datos (interacción con la UI)
        //void EnterEditMode(bool isNew);
        //void ExitEditMode();
        void BindClients(IEnumerable<Client> clients);
        //void LoadEditor(Client client);
        //Client ReadEditor();
        string searchText();
    }
}
