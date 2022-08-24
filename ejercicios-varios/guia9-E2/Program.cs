using System;

namespace guia9_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] articulos = new int[10];
            int[] stock = new int[10];
            double[] precio = new double[10];
            cargarLote1(ref articulos, ref stock, ref precio);
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(articulos[x]);                
            }

        }
        /*funcion cargar vectores*/
        static void cargarLote1(int a, int b, double c)
        {
            for (int x = 0; x < 10; x++)
            {
                int numeroArticulo, cantidadStock;
                double precioUnitario;
                
                Console.WriteLine("Ingrese el numero de articulo ");
                numeroArticulo = int.Parse(Console.ReadLine());
                a[x] = numeroArticulo;
                Console.WriteLine("Ingrese la cantidad de stock ");
                cantidadStock = int.Parse(Console.ReadLine());
                b[x] = cantidadStock;
                Console.WriteLine("Ingrese el precio unitario del articulo ");
                precioUnitario = double.Parse(Console.ReadLine());
                c[x] = precioUnitario;
                
            }
        }
    }
}
