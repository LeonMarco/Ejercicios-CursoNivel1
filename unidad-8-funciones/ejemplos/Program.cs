using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero ");
            n2 = int.Parse(Console.ReadLine());

            // logica
            // llamado a la funcion
            resultado = sumar(n1, n2);
            // fin de logica

            Console.WriteLine("El resultado es " + resultado);
            // SCOPE
        }

        static int sumar(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }
    }
}
