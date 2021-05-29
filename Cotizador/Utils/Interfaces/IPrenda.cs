using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador
{
    public interface IPrenda
    {
        bool IsPremium { get; set; }

        decimal Precio { get; set; }

        int Stock { get; set; }

        decimal Cotizar(int cantidad, decimal precio, bool isPremium);        
    }
}
