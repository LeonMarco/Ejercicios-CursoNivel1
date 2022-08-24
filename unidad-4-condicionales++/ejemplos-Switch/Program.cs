using System;

namespace ejemplos_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
          //Switch
          // Lo vamos a utilizar cuando tengamos que trabajar con opciones
          // No nos va a servir cuando tengamos que trabajar dentro de un rango, por ejemplo si tu sueldo
          // es entre 10000 y 15000. (eso lo hacemos con un if y los concatenadores logicos)
          // No existe switch que no se pueda solucionar con un if
          
          char letra;

          Console.WriteLine("Ingrese una letra");
          letra = char.Parse(Console.ReadLine());

          switch(letra){
              case 'M':
                Console.WriteLine("Tu nombre empieza con M");
                break;
              case 'F':
                Console.WriteLine("Tu nombre empieza con F");
                break;
              case 'J':
                Console.WriteLine("Tu nombre empieza con M");
                break;
              default:
                Console.WriteLine("No coincide con ninguna letra");
                break;

          }  




        }
    }
}
