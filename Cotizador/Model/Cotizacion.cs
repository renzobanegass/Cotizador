using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Cotizacion
    {
        public int num_id { get; set; }

        public DateTime fecha { get; set; }

        public int cod_vendedor { get; set; }

        public IPrenda prenda { get; set; }

        public string nombrePrenda { get; set; }

        public int cantidad { get; set; }

        public decimal total { get; set; }
    }
}
