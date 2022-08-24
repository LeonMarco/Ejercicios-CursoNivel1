using System;

namespace acumuladores_contadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acumuladores y Contadores
            //operador de contador
            //++ , --
            //operador de acumulador
            //+= , -=

            int contador = 0, edad1 = 20, edad2 = 15, edad3 = 30, promedio;
            int acumulador = 0;

            if(edad1 > 18){
                contador++;
                acumulador += edad1;
            }

            if(edad2 > 18){
                contador++;
                acumulador += edad2;
            }

            if(edad3 > 18){
                contador++;
                acumulador += edad3;
            }

            promedio = acumulador / contador;
            Console.WriteLine("El promedio es " + promedio);
        }
    }
}
