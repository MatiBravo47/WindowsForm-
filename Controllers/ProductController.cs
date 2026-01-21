using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Views;

namespace Controllers
{
    class ProductController
    {
        private readonly IProductView _view;
        private readonly IProductRepository _repo;
        private bool _isNew;

        public ProductController(IProductRepository repo, 
                                 IProductView view)
        {
            _view = view;
            _repo = repo;
        }

        public void Init()
        {
            _view.AddRequested += (s, e) => StartAdd();
            _view.EditRequested += (s, e) => StartEdit();
            _view.DeleteRequested += (s, e) => StartDelete();
            _view.SaveRequested += (s, e) => StartSave();
            _view.CancelRequested += (s, e) => StartCancel();
            _view.SearchRequested += (s, e) => StartSearch();

            Seed();
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
            var p = _view.ReadEditor();
            var err = Validate(p);
            if(err != "")
            {
                _view.Error(err);
                return;
            }

            if (_isNew) _repo.Add(p);
            else _repo.Update(p);

            _view.ExitEditMode();
            Refresh();
            _view.Info("guardado");
        }

        private void StartDelete()
        {
            var id = _view.SelectedId();
            if(id == null)
            {
                _view.Info("Elegi un producto.");
                return;
            }
            var p = _repo.GetById(id);
            if(p == null)
            {
                _view.Error("No se encontro el producto.");
                return;
            }
            _repo.Delete(p);
            Refresh();
            _view.Info("Eliminado");
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
            Price = p.Price,
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
            string msg = "";
            if (string.IsNullOrWhiteSpace(p.Name)) 
                msg = "El nombre es obligatorio";

            if (string.IsNullOrWhiteSpace(p.Code))
                msg = "El codigo es obligatorio";
            
            if (_repo.ExistsCode(p.Code, p.id))
                msg = "El producto ya existe";
            
            if (p.Price < 0)
                msg = "El precio debe ser mayor a 0";
            
            if (p.Stock < 0)
                msg = "El stock no puede ser menor a 0";

            return msg;
        }

        private void Seed()
        {
            _repo.Add(new Product
            {
                Code = "A001",
                Active = true,
                Price = 1000,
                Name = "Teclado Gamer",
                Stock = 120
            });
            _repo.Add(new Product
            {
                Code = "A002",
                Active = true,
                Price = 500,
                Name = "Mouse Gamer",
                Stock = 80
            });
        }
    }
}
