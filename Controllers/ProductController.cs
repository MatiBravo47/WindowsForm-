using Model;
using Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Controllers
{
    class ProductController
    {
        //Pantalla windows form
        private readonly IProductView _view;
        //Datos
        private readonly IProductRepository _repo;
        //Saber si esta editando o creando
        private bool _isNew;

        // Inyección de dependencias por constructor:
        // el controller no crea la vista ni el repositorio, los recibe desde afuera
        public ProductController(IProductRepository repo, IProductView view)
        {
            _view = view;
            _repo = repo;
        }

        public void Init()
        {
            //Conecta eventos de la View con métodos del Controller
            _view.AddRequested += (s, e) => StartAdd();
            _view.EditRequested += (s, e) => StartEdit();
            _view.DeleteRequested += (s, e) => StartDelete();
            _view.SaveRequested += (s, e) => StartSave();
            _view.CancelRequested += (s, e) => StartCancel();
            _view.SearchRequested += (s, e) => StartSearch();

            //Carga datos iniciales
            
            //muestra la lista
            Refresh();
        }

        //Solo vuelve a cargar la lista
        //Usa el texto de búsqueda de la view
        private void StartSearch()
        {
            Refresh();
        }

        //Sale del modo edición
        //Vuelve a modo “solo lectura”
        private void StartCancel()
        {
            _view.ExitEditMode();
        }
        

        private void StartSave()
        {
            //Lee los datos que el usuario escribió en la pantalla
            var p = _view.ReadEditor();

            //Si hay error:
                //*Muestra mensaje
                //*Cancela guardado
            var err = Validate(p);
            if(err != "")
            {
                _view.Error(err);
                return;
            }

            //Nuevo o editar
            if (_isNew) _repo.Add(p);
            else _repo.Update(p);


            _view.ExitEditMode();
            Refresh();
            _view.Info("Nuevo producto guardado");
        }

        private void StartDelete()
        {
            var id = _view.SelectedId();
            //Verifica que haya selección
            if (id == null)
            {
                _view.Info("Elegi un producto.");
                return;
            }
            //Busca el producto
            var p = _repo.GetById(id);
            if(p == null)
            {
                _view.Error("No se encontro el producto.");
                return;
            }
            if (!_view.Confirm($"Estas seguro de eliminar el producto?"))
                { 
                return;
                }
            _repo.Delete(p);
            Refresh();
            _view.Info("Producto eliminado con exito");
        }

        private void StartEdit()
        {
            var id = _view.SelectedId();
            if(id == null)
            {
                _view.Info("Elegí un producto");
                return;
            }

            var p = _repo.GetById(id);
            if(p == null)
            {
                _view.Error("NO se encontro el producto.");
                return;
            }

            _isNew = false;
            _view.LoadEditor(Clone(p));
            _view.EnterEditMode(false);
        }

        private static Product Clone(Product p) => new Product()
        {
            id = p.id,
            Code = p.Code,
            Name = p.Name,
            Cost = p.Cost,
            Stock = p.Stock,
            Active = p.Active
        };

        private void StartAdd()
        {
            _isNew = true;
            _view.LoadEditor(new Product());
            _view.EnterEditMode(true);
        }

        private void Refresh()
        {
            var list = _repo.GetAll(_view.searchText());
            _view.BindProducts(list);
        }

        private string Validate(Product p)
        {
            if (string.IsNullOrWhiteSpace(p.Name)) 
                return "El nombre es obligatorio";

            if (string.IsNullOrWhiteSpace(p.Code))
                return "El codigo es obligatorio";
            
            if (_repo.ExistsCode(p.Code, p.id))
                return "El producto ya existe(Codigo repetido)";
            
            if (p.Price < 0)
                return "El precio debe ser mayor a 0";
            
            if (p.Stock < 0)
                return "El stock no puede ser menor a 0";

            return "";
        }
    }
}
