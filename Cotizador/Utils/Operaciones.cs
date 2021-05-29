using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    public class Operaciones
    {
        public static decimal Operacion(decimal Precio, int Porcentaje, bool isAumento)
        {
            decimal resultado = Precio;

            //Calculo de porcentaje del precio
            Precio = (Precio * Porcentaje / 100);

            if (isAumento)
            {
                //Total del precio con aumento
                resultado += Precio;
            }
            else
            {
                //Total del precio con reducción
                resultado -= Precio;
            }

            return resultado;
        }
    }
}
