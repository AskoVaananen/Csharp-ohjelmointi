using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arvosanat = { 0, 0, 0, 0, 0, 0 }; // alussa indexien summat on 0
            
            {
                while (true) //kysyy niin pitkään kunnes antaa jonkun muun numeron kuin 0-5
                {
                    Console.WriteLine("Anna arvosana > ");
                    int arvosana = int.Parse(Console.ReadLine());
                    if (arvosana <= 5 && arvosana >= 0) // && = molemmat ehdot täyttyvät
                    {
                        arvosanat[arvosana]++;
                    }
                    else break;
                }

                for (int i = 0; i < arvosanat.Length; i++) // tulostaa arvosanat taulukon summat
                {
                    Console.Write(i);
                    for (int k = 0; k < arvosanat[i]; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                }




            }
            
            

           

          

            
           
        }
            
    }


