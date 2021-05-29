using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Pantalon : IPrenda
    {
        public bool IsPremium { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Tipo { get; set; }
        public Pantalon( int _stock, string _tipo, decimal _precio = 0, bool _isPremium = false)
        {
            IsPremium = _isPremium;
            Precio = _precio;
            Stock = _stock;
            Tipo = _tipo;            
        }
        public decimal Cotizar(int cantidad, decimal _precio, bool _isPremium)
        {
            decimal Total;

            Precio = _precio;

            switch (Tipo)
            {
                case "Chupin":
                    Precio = Operaciones.Operacion(_precio, 12, false);
                    break;
                default: break;
            }

            if (_isPremium)
            {
                Precio = Operaciones.Operacion(_precio, 30, true);
            }

            if (cantidad > Stock)
            {
                Exception ex = new Exception($"No se puede cotizar sobre esa cantidad de prendas por falta de stock, pruebe con: {Stock}");
                throw ex;
            }

            Total = Precio * cantidad;                       

            return Total;
        }
    }
}
