using Model;
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
        private bool _isNew;

        public ClientController(IClientRepository repo, IClientView view)
        {
            _view = view;
            _repo = repo;
        }

        public void Init()
        {
            // Conecta eventos de la View con métodos del Controller
            _view.AddRequested += (s, e) => StartAdd();
            _view.EditRequested += (s, e) => StartEdit();
            _view.DeleteRequested += (s, e) => StartDelete();
            _view.SaveRequested += (s, e) => StartSave();
            _view.CancelRequested += (s, e) => StartCancel();
            _view.SearchRequested += (s, e) => StartSearch();

            // Carga datos iniciales
            Refresh();
        }

        private void StartSearch()
        {
            Refresh();
        }

        private void StartCancel()
        {
            _view.ExitEditMode();
        }

        private void StartSave()
        {
            var c = _view.ReadEditor();

            // Validación
            var err = Validate(c);
            if (err != "")
            {
                _view.Error(err);
                return;
            }

            // Nuevo o editar
            if (_isNew) _repo.Add(c);
            else _repo.Update(c);

            _view.ExitEditMode();
            Refresh();
            _view.Info("Cliente guardado correctamente");
        }

        private void StartDelete()
        {
            var id = _view.SelectedId();
            if (id == null)
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

        private void StartEdit()
        {
            var id = _view.SelectedId();
            if (id == null)
            {
                _view.Info("Selecciona un cliente");
                return;
            }

            var c = _repo.GetById(id);
            if (c == null)
            {
                _view.Error("No se encontró el cliente.");
                return;
            }

            _isNew = false;
            _view.LoadEditor(Clone(c));
            _view.EnterEditMode(false);
        }

        private static Client Clone(Client c) => new Client()
        {
            id = c.id,
            Name = c.Name,
            Email = c.Email,
            Phone = c.Phone,
            Address = c.Address
        };

        private void StartAdd()
        {
            _isNew = true;
            _view.LoadEditor(new Client());
            _view.EnterEditMode(true);
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
