using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su
            //posición dentro del vector.
            
           int[] vector = new int[10];
           int n, max = 0, pos = 0;

           for (int x = 0; x < 10; x++)
           {
               Console.WriteLine("Ingrese un numero");
               n = int.Parse(Console.ReadLine());
               vector[x] = n;   
           }
           for (int x = 0; x < 10; x++)
           {
               if (vector[x] > max)
               {
                   max = vector[x];
                   pos = x + 1;
               }
           }
            Console.WriteLine("El valor maximo del vector es " + max + " y su posicion es " + pos);

        }
    }
}
