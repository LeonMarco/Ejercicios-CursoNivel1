using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva
            el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad 
            vendida y muestre por pantalla el monto total a pagar. Usar la función.*/
            int n1, n2;
            
            Console.WriteLine("Ingrese el precio del articulo ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El total a pagar es " + producto(n1, n2));
        }
        static int producto(int a, int b)
        {
            return a * b;
        }
    }
}
