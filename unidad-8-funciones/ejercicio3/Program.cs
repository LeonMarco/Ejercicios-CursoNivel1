using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 
            si el número es primo o cero si no lo es. Hacer un programa para ingresar números.
            El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo 
            los números primos.*/
            int n, acumulador = 0, contador = 0, promedio;

            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                if(primo(n) == 1)
                {
                    contador++;
                    acumulador += n;
                }
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de numeros primos es " + promedio);


        }
        static int primo(int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                con++;
            } 
                if (con == 2)
                    return 1;
                else
                    return 0;
        }
    }
}
