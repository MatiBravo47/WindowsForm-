using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Implementación del repositorio de productos usando Repository<T> genérico
    /// </summary>
    public class GenericProductRepository : IProductRepository
    {
        private const string FileName = "products";

        public void Add(Product p)
        {
            Repository.Repository<Product>.Agregar(FileName, p);
        }

        public void Update(Product p)
        {
            Repository.Repository<Product>.Actualizar(FileName, x => x.id == p.id, p);
        }

        public void Delete(Product p)
        {
            Repository.Repository<Product>.Eliminar(FileName, x => x.id == p.id);
        }

        public Product GetById(Guid id)
        {
            var products = Repository.Repository<Product>.ObtenerTodos(FileName);
            return products.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Product> GetAll(string search = null)
        {
            var products = Repository.Repository<Product>.ObtenerTodos(FileName);

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.Trim().ToLowerInvariant();
                products = products.Where(p =>
                    p.Name.ToLowerInvariant().Contains(s) ||
                    p.Code.ToLowerInvariant().Contains(s)
                ).ToList();
            }

            return products.OrderBy(p => p.Name).ToList();
        }

        public bool ExistsCode(string code, Guid? excludeId = null)
        {
            var products = Repository.Repository<Product>.ObtenerTodos(FileName);
            return products.Any(p =>
                p.Code.Equals(code, StringComparison.OrdinalIgnoreCase) &&
                (!excludeId.HasValue || p.id != excludeId.Value)
            );
        }
    }
}
