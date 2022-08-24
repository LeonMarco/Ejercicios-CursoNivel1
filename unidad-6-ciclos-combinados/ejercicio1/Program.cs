using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla
            // cuántos de esos números son primos.

            int n, conPrimos = 0, con;
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                con = 0;
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        con++;
                }
                if (con == 2)
                    conPrimos++;
                
            }
            Console.WriteLine("La cantidad de numeros primos ingresados es: " + conPrimos);


        }
    }
}
