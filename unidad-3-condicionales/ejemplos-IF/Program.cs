using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOQUE IF: Condicionales
            //Estructura IF
            //if(valor OPERADOR RELACIONAL valor){ }

            int edad = 17;

            // if(edad > 20){
            //   if(edad > 30)
            //     Console.WriteLine("30 OFF");
            //   else
            //     Console.WriteLine("21 OFF");
            // }else
            //     Console.WriteLine("10 OFF");
            

            if(edad > 30)
                Console.WriteLine("30 OFF");
            else if(edad > 20)
                Console.WriteLine("21 OFF");
            else if(edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5 OFF");

            Console.WriteLine("Fin del programa");

        }
    }
}
