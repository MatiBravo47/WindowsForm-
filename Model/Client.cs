using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}
