using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo
            // de los números pares y el mínimo de los números impares.
            
            int n, maxPar = 0, minImp = 0;
            bool banP = false, banI = false;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                    if(banP == false){
                        maxPar = n;
                        banP = true;
                    }else if(n > maxPar){
                        maxPar = n;
                    }
                }else if(banI == false){
                    minImp = n;
                    banI = true;
                    }else if(n < minImp)
                        minImp = n;
            
            }
            
            Console.WriteLine("El numero maximo de los pares es: " + maxPar);
            Console.WriteLine("El numero minimo de los impares es: " + minImp);
                    
                

                    
                
                   
        }
    }
}
