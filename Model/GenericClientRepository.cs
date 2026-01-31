using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Implementación del repositorio de clientes usando Repository<T> genérico
    /// </summary>
    class GenericClientRepository : IClientRepository
    {
        private const string FileName = "clients";

        public void Add(Client c)
        {
            Repository.Repository<Client>.Agregar(FileName, c);
        }

        public void Update(Client c)
        {
            Repository.Repository<Client>.Actualizar(FileName, x => x.id == c.id, c);
        }

        public void Delete(Client c)
        {
            Repository.Repository<Client>.Eliminar(FileName, x => x.id == c.id);
        }

        public Client GetById(Guid id)
        {
            var clients = Repository.Repository<Client>.ObtenerTodos(FileName);
            return clients.FirstOrDefault(c => c.id == id);
        }

        public IEnumerable<Client> GetAll(string search = null)
        {
            var clients = Repository.Repository<Client>.ObtenerTodos(FileName);

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.Trim().ToLowerInvariant();
                clients = clients.Where(c =>
                    c.Name.ToLowerInvariant().Contains(s)
                ).ToList();
            }

            return clients.OrderBy(c => c.Name).ToList();
        }
    }
}
