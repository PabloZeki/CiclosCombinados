using System;
//2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
//Se pide determinar e informar:

//El número de grupo con mayor porcentaje de números impares respecto al total de números que 
//forman el grupo.
//Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            const int GRUPOS = 2;
            float Numeros,ContPares = 0,ContImpares = 0,PorcPares=0,PorcImpares=0,MaxImpares=0,MaxgrupoImpar=0,ContOrdenados=0,Minimo=0;
            bool BanImpares = false,BanOrdenados;

                  
                  
                  

            for ( i = 0; i < GRUPOS; i++)
            {
                 Console.WriteLine("Ingrese numeros por favor");
                 Numeros = float.Parse(Console.ReadLine());
                    ContPares=0;
                   ContImpares=0;
                   Minimo=Numeros; //esto cuando da la vuelta se reinicia
                   BanOrdenados=true; // punto b yo aca asumo que estan ordenados
                 while (Numeros!=0)
                 {

                    if(Numeros%2==0){
                        ContPares++;


                    }else{
                        ContImpares++;
                       
                    }
                    //punto b
                    if(Numeros <= Minimo){
                        Minimo=Numeros;
                    }else 
                    {
                        BanOrdenados = false; // con que pase una sola vez por aca me alcanza para saber
                                                // que no esta ordenado,para este caso en particular
                    }
                   
                        
                    Console.WriteLine("Ingrese numeros por favor");
                 Numeros = float.Parse(Console.ReadLine());
              
                 }

                        if(BanOrdenados){
                        ContOrdenados++;
                          }

                 PorcPares = ContPares*100/(ContPares+ContImpares);
                 PorcImpares = ContImpares*100/(ContPares+ContImpares);
               
                 if(PorcImpares > PorcPares ){

                    if(BanImpares){
                      MaxImpares=PorcImpares;
                      BanImpares=true;
                      MaxgrupoImpar=i+1;
                    
                    }else if(PorcImpares > MaxImpares){
                        MaxImpares=PorcImpares;
                        MaxgrupoImpar=i+1;
                    }
                 } else{
                    Console.WriteLine("Hay mas porcentaje de numeros pares ");
                 }                
                 
            }
            Console.WriteLine("El numero de grupo que mas porcentaje de impares tuvo es el :" +MaxgrupoImpar);
           Console.WriteLine("La cantidad de grupos ordenados de forma decreciente son: " +ContOrdenados);
        }
    }
}
