using System;

namespace Model
{
    public class Product
    {
        //Guid es un tipo de dato, igual que int, string, decimal, etc.
        //Guid: Identificador unico, dificil de repetir, evita usar un int autoincremental cuando no tenés base de datos.
        public Guid id { get; set; } = Guid.NewGuid();
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public decimal Cost { get; set; }
        public decimal ProfitMargin { get; set; } = 30; // 30% por defecto
        public decimal Price => Cost * (1 + ProfitMargin / 100);
        public int Stock { get; set; }
        public bool Active { get; set; }
    }
}
