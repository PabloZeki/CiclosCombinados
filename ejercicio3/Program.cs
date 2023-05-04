using System;
//3. Hacer un programa para recibir listas de números positivos que están separadas entre sí 
//por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números
 //tiene cada lista.

 // lo mejor es usar do while



namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros,NumGrupo=0;
            float ContNumeros;

            Console.WriteLine("Ingrese numeros por favor: ");
            Numeros = int.Parse (Console.ReadLine());

            while (Numeros>0)
            {
                ContNumeros = 0;

            while (Numeros!=0&&Numeros>0)
            {
                ContNumeros++;
                


             Console.WriteLine("Ingrese numeros por favor: ");
                Numeros = int.Parse (Console.ReadLine());
            
            }
             NumGrupo++;

            Console.WriteLine("La cantidad de numeros del grupo:"+NumGrupo+ " Es de:" + ContNumeros);
           


                Console.WriteLine("Ingrese numeros por favor: ");
                Numeros = int.Parse (Console.ReadLine());

            }


        }
    }
}
