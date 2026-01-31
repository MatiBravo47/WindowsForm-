using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IClientRepository
    {
        void Add(Client c);
        void Update(Client c);
        void Delete(Client c);
        Client GetById(Guid id);
        IEnumerable<Client> GetAll(string search = null);
    }
}
