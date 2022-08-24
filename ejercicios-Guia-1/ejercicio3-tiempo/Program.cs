using System;

namespace ejercicio3_tiempo
{
    class Program
    {
        static void Main(string[] args)
        {
           //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
           //y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado 
           //que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

           float distancia, velocidad, tiempo;

           Console.WriteLine("ingrese la distancia entre las ciudades");
           distancia = float.Parse(Console.ReadLine());
           Console.WriteLine("ingrese la velocidad promedio");
           velocidad = float.Parse(Console.ReadLine());

           tiempo = distancia / velocidad;
           Console.WriteLine("El tiempo aproximado es " + tiempo.ToString("0.00") + " horas. "); 

        }
    }
}
