using Model;
using System;
using System.Windows.Forms;
using Views;

namespace Controllers
{
    /// <summary>
    /// Controlador para la gestión de clientes
    /// </summary>
    class ClientController
    {
        private readonly IClientView _view;
        private readonly IClientRepository _repo;

        public ClientController(IClientRepository repo, IClientView view)
        {
            _view = view;
            _repo = repo;
        }

        public void Init()
        {
            // Conecta eventos de la View con métodos del Controller
            _view.AddRequested += OnAddRequested;
            _view.EditRequested += OnEditRequested;
            _view.DeleteRequested += (s, e) => StartDelete();
            _view.SearchRequested += (s, e) => StartSearch();

            // Carga datos iniciales
            Refresh();
        }

        private void OnAddRequested(object sender, ClientEventArgs e)
        {
            var newClient = e.Client;

            // Validación
            var err = Validate(newClient);
            if (err != "")
            {
                _view.Error(err);
                return;
            }

            _repo.Add(newClient);
            Refresh();
            _view.Info("Cliente agregado correctamente");
        }

        private void OnEditRequested(object sender, ClientEventArgs e)
        {
            var editedClient = e.Client;

            // Validación
            var err = Validate(editedClient);
            if (err != "")
            {
                _view.Error(err);
                return;
            }

            _repo.Update(editedClient);
            Refresh();
            _view.Info("Cliente actualizado correctamente");
        }
        private void StartSearch()
        {
            Refresh();
        }
        

        private void StartDelete()
        {
            var id = _view.SelectedId();
            if (id == null || id == System.Guid.Empty)
            {
                _view.Info("Selecciona un cliente.");
                return;
            }

            var c = _repo.GetById(id);
            if (c == null)
            {
                _view.Error("No se encontró el cliente.");
                return;
            }

            if (!_view.Confirm("Estas seguro que desea eliminar el cliente"))
            {
                return;
            }

            _repo.Delete(c);
            Refresh();
            _view.Info("Cliente eliminado con éxito");
        }

        private void Refresh()
        {
            var list = _repo.GetAll(_view.searchText());
            _view.BindClients(list);
        }

        private string Validate(Client c)
        {
            if (string.IsNullOrWhiteSpace(c.Name))
                return "El nombre es obligatorio";

            return "";
        }
    }
}
