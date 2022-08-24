using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores - Array - Arreglo
            //Para cargar un vector lo hacemos con un ciclo FOR

            //int n;
            //int[] numeros = new int[10];
            //for (int x = 0; x < 10; x++)
            //{
              //  Console.WriteLine("Ingrese un numero ");
                //n = int.Parse(Console.ReadLine());
                //numeros[x] = n;
                // La x del ciclo FOR nos va a determinar el indice del vector donde
                // se va a cargar el valor de n (de 0 a 9)
            //}
            // Para leer el vector tambien lo hacemos con un ciclo FOR
            // En este ejemplo sumamos los valores del vector y calculamos un promedio.
            //int acu = 0, promedio;

            //for (int x = 0; x < 10; x++)
            //{
            //    acu += numeros[x];
            //}
            //promedio = acu / 10;
            //Console.WriteLine("El promedio es " + promedio);

            //VECTORES DOUBLE
            //Cargar un vector con temperaturas de todo el mes

            //int dia;
            //double temperatura;
            //double[] muestraMatutina = new double[31];

            //Console.WriteLine("Registro de temperaturas");

            //for (int x = 0; x < 31; x++)
            //{
            //    Console.WriteLine("Ingrese dia ");
            //    dia = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese temperatura ");
            //    temperatura = double.Parse(Console.ReadLine());

            //    muestraMatutina[dia-1] = temperatura;
            //}   
            // Leer vector
            //for (int x = 0; x < 31; x++)
            //{
            //    Console.WriteLine("Las temperaturas del mes fueron " + muestraMatutina[x]);

            //}
            // VECTORES TIPO BOOL
            // Nos sirve para registrar algo que su resultado se verdadero o falso
            // por ejemplo las asistencias de personas al trabajo o a una cursada en la universidad.

            int dia;
            bool asistencias = false;
            bool[] asistenciasTotales = new bool[31];
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese dia ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese asistencia");
                asistencias = bool.Parse(Console.ReadLine());

                asistenciasTotales[dia-1] = asistencias;
            }for (int x = 0; x < 5; x++)
            {
                if (asistenciasTotales[x])
                    Console.WriteLine("El dia " + (x + 1) + " asistio ");
                else
                    Console.WriteLine("El dia " + (x + 1) + " no asistio ");
                

            }
        }

    }
}
