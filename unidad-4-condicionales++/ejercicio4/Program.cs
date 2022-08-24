using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            //si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a, b, c;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c))
                Console.WriteLine("La suma es mayor al producto");
            else
                Console.WriteLine("El producto es mayor a la suma");
            
        }
    }
}
