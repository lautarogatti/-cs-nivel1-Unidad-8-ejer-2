using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/
            int contadorPar = 0, n;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if(par(n) == 1){
                    contadorPar++;
                }
            }
            
            Console.WriteLine("La cantidad de números pares ingresados es " + contadorPar);
        }

        static int par(int n){
            int r = 0;
            if (n % 2 == 0){
                r = 1;
            }
            return r;
        }
    }
}
