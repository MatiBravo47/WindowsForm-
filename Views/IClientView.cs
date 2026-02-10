using System;
using System.Collections.Generic;
using Model;

namespace Views
{
    /// <summary>
    /// Interfaz para la vista de clientes
    /// </summary>
    public interface IClientView
    {
        // Eventos: avisa que el usuario lo pidió
        event EventHandler<ClientEventArgs> AddRequested;
        event EventHandler<ClientEventArgs> EditRequested;
        event EventHandler DeleteRequested;
        event EventHandler SearchRequested;

        // Feedback (respuesta al usuario)
        Guid SelectedId();
        void Info(string msg);
        void Error(string msg);
        bool Confirm(string msg);

        void BindClients(IEnumerable<Client> clients);
        string searchText();
    }
}
