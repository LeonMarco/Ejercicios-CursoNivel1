using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos 
            //y luego mostrar por pantalla el mayor de ellos.

            int n1, n2, n3, n4, mayor;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2)
                mayor = n1; 
            else
                mayor = n2;
            
            if(n3 > mayor)
                mayor = n3;
            
            if(n4 > mayor)
                mayor = n4;
            
            Console.WriteLine("El numero mayor es " + mayor);


        }
    }
}
