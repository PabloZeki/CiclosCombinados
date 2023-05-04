using System;
//1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla 
//cuántos de esos números son primos.

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros,i,ContPrimos=0,Cont,j;
            const int VUELTAS = 10;
            for ( i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingresar 10 numeros por favor: ");
                 Numeros = int.Parse(Console.ReadLine());
                    Cont=0;
                    j=1;
                while (j<=Numeros)
                {
                    if(Numeros%j==0){
                        Cont++;
                    }
                    j++;
                }
                if(Cont==2){

                    ContPrimos++;
                }

            }
            Console.WriteLine("La cantidad de numeros primos son: " +ContPrimos);
           
        }
    }
}
