using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           //  5. Hacer un programa para ingresar cuatro números
           //  y luego mostrar por pantalla cuáles son mayores a 100.

           int n1, n2, n3, n4;
           Console.WriteLine("ingrese un numero");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese otro");
           n2 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese otro");
           n3 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese otro");
           n4 = int.Parse(Console.ReadLine());

            if(n1 > 100)
               Console.WriteLine("Son mayores a 100: " + n1);
            if(n2 > 100)
                Console.WriteLine(n2);
            if(n3 > 100)
                Console.WriteLine(n3);
            if(n4 > 100)
                Console.WriteLine(n4);
        }

    }
}
