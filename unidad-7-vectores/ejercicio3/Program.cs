using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos 
            //(tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer 
            //carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
            
            char[] cadena = new char[20];
            char letra1, letra2, letra;

            Console.WriteLine("Ingrese una frase letra por letra , para finalizar ingrese un punto");
            letra = char.Parse(Console.ReadLine());
            int indice = 0;
            while (letra != '.' && indice < 20)
            {
                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            cadena[indice] = '\0';
            Console.WriteLine("La frase ingresada es ");
            indice = 0;
            while (cadena[indice] != '\0' &&  indice < 20)
            {
                Console.Write(cadena[indice]);
                indice++;    
            }
            
            Console.WriteLine("Ingrese la letra a reemplazar ");
            letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva ");
            letra2 = char.Parse(Console.ReadLine());

            indice = 0;
            while (cadena[indice] != '\0' && indice < 20)
            {
                if (cadena[indice] == letra1)
                    cadena[indice] = letra2;
                
                indice++;
            }

            indice = 0;
            Console.WriteLine("Tu frase nueva es ");
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }
        }
    }
}
