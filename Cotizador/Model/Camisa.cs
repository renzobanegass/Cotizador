using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Camisa : IPrenda
    {
        public bool IsPremium { get ; set; }
        public decimal Precio { get; set; }
        public int Stock { get ; set; }
        public string TipoManga { get; set; }
        public string TipoCuello { get; set; }
        public Camisa( int _stock, string _tipoManga, string _tipoCuello, decimal _precio = 0, bool _isPremium = false)
        {
            IsPremium = _isPremium;
            Precio = _precio;
            Stock = _stock;
            TipoManga = _tipoManga;
            TipoCuello = _tipoCuello;
        }
        public decimal Cotizar(int cantidad, decimal _precio, bool _isPremium)
        {

            Precio = _precio;

            switch (TipoManga)
            {
                case "Corta":
                    Precio = Operaciones.Operacion(_precio, 10, false);
                    break;
                 default: break;
            }

            switch (TipoCuello)
            {                
                case "Mao":
                    Precio = Operaciones.Operacion(_precio, 3, true);
                    break;
                default: break;
            }

            if (_isPremium)
            {
               Precio = Operaciones.Operacion(_precio, 30, true);
            }
            
            if(cantidad > Stock)
            {
                Exception ex = new Exception($"No se puede cotizar sobre esa cantidad de prendas por falta de stock, pruebe con: {Stock}");
                throw ex;
            }

            decimal Total = Precio * cantidad;

            return Total;
        }
    }
}
