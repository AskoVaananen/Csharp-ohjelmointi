using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Lotto
    {
        Random rand;
           
        public Lotto()
        {
             rand = new Random();

        }
        public int[] Generate() // generate new row and return it 
        {
            int check = 0;
          
            int[] lotto = new int[7];
            
            
            for (int i = 0; i < lotto.Length; ) //generate seven random integers between 1-40
            {
                check = rand.Next(1, 40); 
                while (!(lotto.Contains(check))) // if there is duplicate integer, generate again.
                {
                    lotto[i] = check;
                    i++;
                }
                


                    
                }
            return lotto;
                    
            
                
            }
        /*public void PrintData()
        {



        }
        */

        }

    }
       
  


