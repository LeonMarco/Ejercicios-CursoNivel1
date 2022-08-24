using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3. Hacer un programa que solicite 20 edades
            //y luego calcule el promedio de edad de aquellas personas mayores a 18 años
            
            int edad = 0, con = 0, acu = 0, promedio;
            for (int x = 0; x < 20; x++){
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                if(edad > 18)
                    con++;
                    acu += edad;   
            }
                promedio = acu / con;
                Console.WriteLine("El promedio es " + promedio);
        }
    }
}
