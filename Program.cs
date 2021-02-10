using System;
using System.Collections.Generic;

namespace Visilica
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.newWord = SearchWords.Search();

            Game.Shifr();

            string character;
            
            do 
            {
                if (Game.ChekingForEnd())
                    break;

                Game.WriteGame();

                character = CheckingForErrors.ErrorInOutputCharacter();

                Game.ReadCharacter(character);

                Console.Clear();


            } while (character != "exit");

        }
    }
    public class SearchWords
    {
        private static string[] words = { "ЗАСОР", "ВАКУМ", "РАСТИТЕЛЬНОСТЬ", "ВИСИЛИЦА", "МАНДАРИН" };
        public static string Search()
        {
            var rnd = new Random();

            return words[rnd.Next(0, words.Length)];
        }
    }
    
    

    
}
