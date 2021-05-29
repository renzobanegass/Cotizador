using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Vendedor
    {
        public int codvendedor { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        private List<Cotizacion> cotizaciones { get; set; }
        public Vendedor(int Codigo, string Nombre, string Apellido)
        {
            codvendedor = Codigo;
            nombre = Nombre;
            apellido = Apellido;
            cotizaciones = new List<Cotizacion>();
        }
        public decimal Cotizar(IPrenda _prenda, string _nombrePrenda, decimal _precio , bool _isPremium , int cantidad)
        {
            Cotizacion oCotizacion = new Cotizacion();

            oCotizacion.num_id = cotizaciones.Count + 1;
            oCotizacion.cod_vendedor = this.codvendedor;
            oCotizacion.fecha = DateTime.Now;
            oCotizacion.prenda = _prenda;
            oCotizacion.nombrePrenda = _nombrePrenda;
            oCotizacion.cantidad = cantidad;
            oCotizacion.total = _prenda.Cotizar(cantidad, _precio, _isPremium);

            cotizaciones.Add(oCotizacion);

            return oCotizacion.total;
        }

        public void Historial()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Historial de Cotizaciones");

            foreach (var item in cotizaciones)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Numero de Identificacion: {item.num_id}");
                Console.WriteLine($"Codigo del Vendedor: {item.cod_vendedor}");
                Console.WriteLine($"Fecha y Hora: {item.fecha}");
                Console.WriteLine($"Prenda cotizada: {item.nombrePrenda} {(item.prenda.IsPremium ? "Premium" : "Standard")}");
                Console.WriteLine($"Cantidad de unidades cotizadas: {item.cantidad}");
                Console.WriteLine($"Total: {item.total}");
                Console.WriteLine("------------------");
            }  
        }
    }
}
