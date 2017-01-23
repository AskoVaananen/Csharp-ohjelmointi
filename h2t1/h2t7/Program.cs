using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace h2t7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random((int)DateTime.Now.Ticks); // randomin alustus, valitsee randomin jotenkin ajan mukaan

            string[] sanat = { "apina", "kissa", "koira", "hevonen", "hiiri", "sika","orava","KÄÄRME" }; // sanat jota pelissä arvataan

            string arvattava_sana = sanat[random.Next(0, sanat.Length)]; //Valitsee randomin sanan valmiista listasta "sanat"
            

            StringBuilder sanan_naytto = new StringBuilder(arvattava_sana.Length); // tekee randomi sanasta alussa piilotetun "_" merkeillä
            for (int i = 0; i < arvattava_sana.Length; i++) // yhtä monta alaviivaa kuin randomisanassa
                sanan_naytto.Append('_');

            List<char> oikein_arvatut = new List<char>(); // tähän listaan tulee oikein arvatut kirjaimet
            List<char> vaarin_arvatut = new List<char>(); // tähän listaan tulee väärin arvatut kirjaimet

            int lives = 5; // viisi arvausta
            bool won = false; // alussa false 
            int oikeinarvatut = 0; //

            string input; // syöte jota pelaaja laittaa eli kirjain
            char guess; // guessi on inputin syöte jota siitä tulee

            while (!won && lives > 0)
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToLower(); // muuttaa syötetyn kirjaimen pieneksi
                guess = input[0]; // inputin ensimmäinen kirjain

                if (oikein_arvatut.Contains(guess)) // jos arvaa uudestaan saman kirjaimen joka oikein
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (vaarin_arvatut.Contains(guess)) // jos arvaa uudestaan saman kirjaimen joka on väärin
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (arvattava_sana.Contains(guess)) // jos arvattavassa sanassa on arvattu kirjain
                {
                    oikein_arvatut.Add(guess); // lisätään oikein arvattujen listaan arvattu kirjain

                    for (int i = 0; i < arvattava_sana.Length; i++)
                    {
                        if (arvattava_sana[i] == guess)
                        {
                            sanan_naytto[i] = arvattava_sana[i];
                            oikeinarvatut++;
                        }
                    }

                    if (oikeinarvatut == arvattava_sana.Length)
                        won = true; //boolean value winwinwinwin
                }
                else
                {
                    vaarin_arvatut.Add(guess);

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                    lives--;
                }

                Console.WriteLine(sanan_naytto.ToString());
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", arvattava_sana);

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}