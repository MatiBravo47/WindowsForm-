/*
🔹 Define qué se puede hacer con productos
🔹 No dice cómo
🔹 Permite cambiar de base de datos sin romper nada
*/

using System;
using System.Collections.Generic;

namespace Model
{
    interface IProductRepository
    {
        void Add(Product p);
        void Update(Product p);
        void Delete(Product p);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll(string search = null);
        
        //evita productos duplicados
        bool ExistsCode(string code, Guid? excludeId = null);
    }
}
