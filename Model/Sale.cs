using System;

namespace Model
{
    /// <summary>
    /// Modelo de Venta - vincula un cliente con un producto
    /// </summary>
    public class Sale
    {
        public Guid id { get; set; } = Guid.NewGuid();

        // Referencia al cliente
        public Guid ClientId { get; set; }
        public string ClientName { get; set; } // Denormalizado para facilitar consultas

        // Referencia al producto
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } // Denormalizado
        public string ProductCode { get; set; } // Denormalizado

        // Detalles de la venta
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }

        // Fecha de la venta
        public DateTime SaleDate { get; set; } = DateTime.Now;
    }
}
