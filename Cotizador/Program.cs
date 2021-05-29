using Cotizador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializaciones            

            //Vendedores
            List<Vendedor> vendedores = new List<Vendedor>();

            Vendedor vendedorUno = new Vendedor(5, "Renzo", "Banegas");
            vendedores.Add(vendedorUno);

            //Prendas
            List<Camisa> camisas = new List<Camisa>();
            List<Pantalon> pantalones = new List<Pantalon>();


            //Stocks
            Camisa camisaCortaMao= new Camisa(200, "Corta", "Mao");
            camisas.Add(camisaCortaMao);
            Camisa camisaCortaComun = new Camisa(300, "Corta", "Comun");
            camisas.Add(camisaCortaComun);
            Camisa camisaLargaMao = new Camisa(150, "Larga", "Mao");
            camisas.Add(camisaLargaMao);
            Camisa camisaLargaComun = new Camisa(350, "Larga", "Comun");
            camisas.Add(camisaLargaComun);
            Pantalon pantalonChupin = new Pantalon(1500, "Chupin");
            pantalones.Add(pantalonChupin);
            Pantalon pantalonComun = new Pantalon(500, "Comun");
            pantalones.Add(pantalonComun);

            //Tienda
            Tienda tienda = new Tienda("XModa", "Av. Avellaneda 2801", pantalones, camisas, vendedores);

            Vendedor vendedorActual = tienda.Vendedores.FirstOrDefault();

            //Interfaz

            string linea = string.Empty;
            int opcion = 0, cantidad;
            decimal precio;            
            string prenda = "Pantalon";
            string tipo = "Comun";
            string tipoManga = "Corta";
            string tipoCuello = "Comun";
            bool isPremium = false;
            decimal Total = 0;
           

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Vendedor: {vendedorActual.nombre} {vendedorActual.apellido} - Codigo de Vendedor: {vendedorActual.codvendedor}");
            Console.WriteLine("C. Ver Historial");

            while(linea != "C")
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Prenda a cotizar: ");
                    Console.WriteLine("1. Camisa\n2. Pantalón");
                    linea = Console.ReadLine();                                                            
                    opcion = int.Parse(linea);
                    Console.WriteLine("----------------------------------------------------");
                    switch (opcion)
                    {
                        case 1:
                            prenda = "Camisa";
                            Console.WriteLine("Camisa, Tipo de Manga: ");
                            Console.WriteLine("1. Corta\n2. Larga");
                            linea = Console.ReadLine();
                            opcion = int.Parse(linea);

                            if (opcion == 2)
                            {
                                tipoManga = "Larga";
                            }

                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"Camisa, Manga {tipoManga}, Tipo de Cuello: ");
                            Console.WriteLine("1. Común\n2. Mao");
                            linea = Console.ReadLine();
                            opcion = int.Parse(linea);

                            if (opcion == 2)
                            {
                                tipoCuello = "Mao";
                            }

                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"Camisa, Manga {tipoManga}, Cuello {tipoCuello} ");

                            break;
                        case 2:
                            Console.WriteLine("Pantalón, Tipo: ");
                            Console.WriteLine("1. Común\n2. Chupin");
                            linea = Console.ReadLine();
                            opcion = int.Parse(linea);

                            if (opcion == 2)
                            {
                                tipo = "Chupin";
                            }

                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"Pantalón, {tipo}");
                            break;
                    }
                    Console.WriteLine("----------------------------------------------------");

                    Console.WriteLine("Calidad de prenda: ");
                    Console.WriteLine("1. Standard\n2. Premium");
                    linea = Console.ReadLine();
                    opcion = int.Parse(linea);

                    if (opcion == 2)
                    {
                        isPremium = true;
                    }

                    Console.WriteLine("----------------------------------------------------");

                    Console.WriteLine($"Camisa, Manga {tipoManga}, Cuello {tipoCuello} , {(isPremium == true ? "Premium" : "Standard")}");

                    Console.WriteLine("Ingrese el precio de la prenda a cotizar: ");
                    linea = Console.ReadLine();
                    precio = decimal.Parse(linea);

                    Console.WriteLine("----------------------------------------------------");

                    Console.WriteLine($"Camisa, Manga {tipoManga}, Cuello {tipoCuello} , {(isPremium == true ? "Premium" : "Standard")}, Precio por unidad: {precio}");

                    Console.WriteLine("Ingrese la cantidad de prendas a cotizar: ");
                    linea = Console.ReadLine();
                    cantidad = int.Parse(linea);

                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Camisa, Manga {tipoManga}, Cuello {tipoCuello} , {(isPremium == true ? "Premium" : "Standard")}, Precio por unidad: {precio}, Cantidad: {cantidad}");


                    IPrenda aCotizar = pantalones.FirstOrDefault();

                    if (prenda == "Pantalon")
                    {
                        aCotizar = pantalones.FirstOrDefault(x => x.Tipo == tipo);
                    }
                    else
                    {
                        aCotizar = camisas.FirstOrDefault(x => x.TipoCuello == tipoCuello && x.TipoManga == tipoManga);
                    }

                    Total = vendedorActual.Cotizar(aCotizar, prenda, precio, isPremium, cantidad);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Total: {Total}");
            }

            if (linea == "C")
            {
                vendedorActual.Historial();

                linea = string.Empty;
            }
             
           
            Console.ReadKey();

        }
    }
}
