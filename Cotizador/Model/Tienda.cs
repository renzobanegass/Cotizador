using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Tienda
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public List<Pantalon> Pantalones { get; set; }

        public List<Camisa> Camisas { get; set; }
            
        public List<Vendedor> Vendedores { get; set; }

        public Tienda(string _nombre, string _direccion, List<Pantalon> _pantalones, List<Camisa> _camisas, List<Vendedor> _vendedores)
        {
            Nombre = _nombre;
            Direccion = _direccion;
            Pantalones = _pantalones;
            Camisas = _camisas;
            Vendedores = _vendedores;
        }
    }
}
