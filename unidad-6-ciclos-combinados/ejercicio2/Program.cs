using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:
                //El número de grupo con mayor porcentaje de números impares respecto al total de números 
                //que forman el grupo.
                //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int conOrdenados = 0;
            double mayorPorcentaje = 0;
            int conGrupos = 0;

            for (int x = 0; x < 5; x++)
            {
                int n, conImpar = 0, con = 0, min = 0;
                double porcentaje;
                bool banOrdenados = true;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                while (n != 0)
                {
                    con++;
                    if (n % 2 != 0)
                        conImpar++;                       
                    if (con == 1)
                        min = n;
                    else if(n <= min)
                        min = n;
                    else
                        banOrdenados = false;
                    
                    Console.WriteLine("Ingrese otro numero");
                    n = int.Parse(Console.ReadLine());
                }
                porcentaje = conImpar * 100f / con;
                
                if(x == 0){
                    mayorPorcentaje = porcentaje;
                }else if(porcentaje >= mayorPorcentaje){
                   mayorPorcentaje = porcentaje;
                   conGrupos = x + 1;
                }
                if (banOrdenados)
                    conOrdenados++;
            }
            Console.WriteLine("El numero de grupo con mayor porcentaje de numero impares es: " + conGrupos);                
            Console.WriteLine("La cantidad de grupos ordenados de mayor a menor es: " + conOrdenados);

        }
    }
}
