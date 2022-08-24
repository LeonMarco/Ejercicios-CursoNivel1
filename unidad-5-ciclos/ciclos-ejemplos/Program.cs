using System;

namespace ciclos_ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO FOR
            // Declaracion de variable; condicion (valor op valor); incremento;
            //for (int x = 0; x < 5; x++){
            //    Console.WriteLine("Hola mundo " + (x + 1));
            //}

            //CICLO WHILE
            // ...mientras >> condicion (valor op valor) se cumpla, el ciclo sigue iterando.
            int n, con = 0;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            while (n != 0){
                con++;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresaste: " + con + " numeros");

        }
    }
}
