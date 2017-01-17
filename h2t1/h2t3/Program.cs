using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            Console.WriteLine("Anna rivimäärä > ");
            luku = int.Parse(Console.ReadLine());
            luku = luku - 2;



            for (int laskuri = 0; laskuri < luku; laskuri++) // tulostetaan puu
            {
                for (int j = 0; j < luku-laskuri; j++)
                {
                    Console.Write(" "); // tässä tulee tyhjät välilyönnit puuhun

                }


            for (int tyhja_laskuri = 0; tyhja_laskuri < laskuri*2 + 1; tyhja_laskuri++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // varsinaiset merkit


            }
            for (int j = 0; j < 2; j++)
            {
                    for (int l = 0; l < luku; l++)
                    {
                        Console.Write(" "); // jalan tyhjät lyönnit

                    }


                    for (int tyhja_laskuri = 0; tyhja_laskuri < 1; tyhja_laskuri++)
                    {
                        Console.Write("*"); // jalan merkit
                    }
                    Console.WriteLine();
                }
          
        }
    }
}
    

