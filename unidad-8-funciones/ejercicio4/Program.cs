using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
            que reciba un número por valor y una variable por referencia. Que analice el número y escriba 
            variable recibida por referencia con:
                a. 1 si el número es positivo.
                b. -1 si el número es negativo.
                c. 0 si el número es cero.*/

            int n, a = 0;
            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(n, ref a);

        }
        static void positivoNegativoCero(int numero, ref int h)
        {
            if (numero == 0){
                h = 0;
                Console.WriteLine("variable recibida por referencia por " + h);
            }
            else if(numero > 0){
                h = 1;
                Console.WriteLine("Variable recibida por referencia por " + h);
            }
            else{
                h = -1;        
                Console.WriteLine("Variable recibida por referencia por " + h);
            }
        }
    }
}
