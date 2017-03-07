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
        public int[] Generate()
        {
            int check = 0;
          
            int[] lotto = new int[7];
            
            
            for (int i = 0; i < lotto.Length; )
            {
                check = rand.Next(1, 41);
                while (!(lotto.Contains(check)))
                {
                    lotto[i] = check;
                    i++;
                }
                


                    
                }
            return lotto;
                    
            
                
            }
        public void PrintData()
        {



        }

        }

    }
       
  


