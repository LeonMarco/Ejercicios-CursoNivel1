using System;

namespace ejercicio3_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letra1, letra2;
            Console.WriteLine("Ingrese la frase ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar ");
            letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva ");
            letra2 = char.Parse(Console.ReadLine());

            frase = frase.Replace(letra1, letra2);

            Console.WriteLine("La nueva frase es ");
            Console.WriteLine(frase);
        }
    }
}
