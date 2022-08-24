using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
            //con los siguientes datos:
            //Número de Artículo (1 a 15)
            //Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo
            //igual a 0.
            //Se pide determinar e informar:
                //a) El número de artículo que más se vendió en total.
                //b) Los números de artículos que no registraron ventas.
                //c) Cuantas unidades se vendieron del número de artículo 10.
                
            int[] articulos = new int[15];
            int numeroArticulo;
            for (int x = 0; x < 15; x++)
            {  
                articulos[x] = x + 1;
            }
            int[] Vacu = new int[15];
            for (int x = 0; x < 15; x++)
            {
                Vacu[x] += 0;
            }
            int[] vPuntob = new int[15];
            for (int x = 0; x < 15; x++)
            {
                vPuntob[x] = 1;
            }
            int cantidadVendida;
            Console.WriteLine("REGISTRO DE VENTAS ");
            Console.WriteLine("Ingrese numero de articulo ");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida ");
            cantidadVendida = int.Parse(Console.ReadLine());
            while (numeroArticulo != 0)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (articulos[x] == numeroArticulo)
                    {
                        Vacu[x] += cantidadVendida;
                        vPuntob[x] = 0;   
                    }
                }
            Console.WriteLine("Ingrese numero de articulo ");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida ");
            cantidadVendida = int.Parse(Console.ReadLine());
            }
            int max = Vacu[0], articuloMax = 1;
            for (int x = 0; x < 15; x++)
            {
                if (Vacu[x] > max)
                {
                    max = Vacu[x];
                    articuloMax = x + 1;
                }
            }
            for (int x = 0; x < 15; x++)
            {
                if (vPuntob[x] == 1)
                {
                    Console.WriteLine("El articulo " + articulos[x] + " no ha registrado ventas");
                }
            }
            Console.WriteLine("El articulo numero " + articuloMax + " es el mas vendido ");
            Console.WriteLine("La cantidad vendida del articulo numero 10 fue de " + Vacu[9]);
        }
    }
}
