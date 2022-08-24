using System;

namespace ejercicio_1_guia_1
{
    class Program
    {
        static void Main(string[] args)
        {  //1. Hacer un programa para solicitar dos números
           //y luego calcule y emita la suma en pantalla.
           
           //paso 0: declarar variables (tipo de dato)
           int n1, n2, resultado;
           //paso 1: pedir valores
           Console.WriteLine("Ingrese un numero:");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese otro");
           n2 = int.Parse(Console.ReadLine());

           //paso 2: realizar calculo
           resultado = n1 + n2;

           //paso 3: emitir resultado
           Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
