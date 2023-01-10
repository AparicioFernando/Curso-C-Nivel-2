using System;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Primer lote con 10 registros de productos, cada producto tiene:
                -Código Articulo (3 digitos no correlativos)
                -Precio
                -Código de Marca (1 al 10)
            Segundo lote con las ventas de la semana. Cada venta tiene:
                -Código Artículo
                -Cantidad
                -Código Cliente (1 al 100)
            Este lote corta con Código de Cliente cero
             */

            Articulo[] articulos = new Articulo[10];    //me creo un vector para 10 objetos de la clase

            for (int x=0;x<10;x++) 
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Código: ");
                articulos[x].CodigoArticulo=int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Código de Marca (1 al 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Código Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            

            while (venta.CodigoCliente!=0)
            {
                
                Console.WriteLine("Código Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos....

                //pido cliente nuevamente:
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }

        }
    }
}
