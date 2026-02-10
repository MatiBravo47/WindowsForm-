using System;
using Model;

namespace Views
{
    /// <summary>
    /// EventArgs personalizado para transportar un objeto Client en eventos
    /// </summary>
    public class ClientEventArgs : EventArgs
    {
        public Client Client { get; }

        public ClientEventArgs(Client client)
        {
            Client = client;
        }
    }
}
