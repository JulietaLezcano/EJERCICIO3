using System;

using System.Linq;

using System.Collections.Generic;


namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado un valor numérico entero m, determinar e imprimir un listado con los m primeros múltiplos de 3 que no sean múltiplos de 5
            List <int> multiplos = new List <int>();
            Console.WriteLine("Indique el numero de multiplos de 3 que desea obtener");
            int m= Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i<multiplos.Count(); i++)
            {
                
                   do{
                        multiplos.Add(i);
                     } while (i%3==0 & i%5!=0);
                     {
                        foreach(var num in multiplos)
            
                        Console.WriteLine("{}",num);
            
                     }
             
                         


                   
                
                   

                    

                
            }


        }
    }
}
