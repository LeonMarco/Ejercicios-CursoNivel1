using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con;

            do
            {
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                con = 0;
                while (n > 0)
                {
                    con++;
                    Console.WriteLine("Ingrese otro numero ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad de numeros de cada lista es " + con);
                
            }while(n >= 0);
            


        }
    }
}
