using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores
            //que son mayores al promedio.
            
            int[] vector = new int[10];
            int n, promedio = 0, acu = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                vector[x] = n;
            }
            for (int x = 0; x < 10; x++)
            {
                acu+= vector[x];
            }
            promedio = acu / 10;
            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > promedio)
                {
                    Console.WriteLine("Los valores mayores al promedio son " + vector[x]);
                }
            }
        }
    }
}
