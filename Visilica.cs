using System;
using System.Collections.Generic;

namespace Visilica
{
    public class Data
    {
        public static string[] Words = { "ЗАСОР", "ВАКУМ", "РАСТИТЕЛЬНОСТЬ", "ВИСИЛИЦА", "МАНДАРИН" };

        public static string NewWord = "";

        public static List<string> Characters = new List<string>();

        public static string[] MassiveInput;

        public static string Try = "7";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data.NewWord = SearchWords.Search();

            Game.Shifr();
            
            string Character;

            do 
            {
                if (Game.ChekingForEnd())
                    break;

                Game.WriteGame();

                Character = CheckingForErrors.ErrorInOutputCharacter();

                Game.ReadCharacter(Character);

                Console.Clear();


            } while (Character != "exit");


        }
    }
    public class SearchWords
    {
        public static string Search()
        {
            Random rnd = new Random();

            return Data.Words[rnd.Next(0, Data.Words.Length)];
        }
    }
    public class Game
    {
        public static void Shifr()
        {
            //Data.NewWord.ToCharArray();

            foreach (var i in Data.NewWord)
                Data.Characters.Add(i.ToString());

            Data.MassiveInput = new string[Data.Characters.Count];

            for (int i = 0; i < Data.MassiveInput.Length; i++)
                Data.MassiveInput[i] = "-";

        }
        public static void WriteGame()
        {
            foreach(var i in Data.MassiveInput)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine(Data.Try);
        }
        public static void ReadCharacter(string bukv)
        {
            if (Data.Characters.Contains(bukv))
            {
                Game.TrueCharacter(bukv);
            }
            else
            {
                Game.FalseCharacter();
            }
        }
        private static void TrueCharacter(string bukv)
        {
            int ind = Data.Characters.IndexOf(bukv);

            Data.MassiveInput[ind] = bukv;

            Data.Characters[ind] = "*";

        }
        private static void FalseCharacter()
        {
            Data.Try = (int.Parse(Data.Try) - 1).ToString();
        }
        public static bool ChekingForEnd()
        {
            int NumberOfEmptyFields = 0;

            foreach (var i in Data.MassiveInput)
            {
                if (i == "-")
                {
                    NumberOfEmptyFields++;
                }
            }

            if (NumberOfEmptyFields > 0)
                return false;
            else
                return true;

        }

    }
    class CheckingForErrors
    {
        public static string ErrorInOutputCharacter()
        {
            string character;

            do 
            {
                character = Console.ReadLine().ToUpper();

                if(character.Length > 1)
                {
                    Console.WriteLine("Вы ввели больше 1 буквы");
                }
                else if(Convert.ToChar(character) < 'А' || Convert.ToChar(character) > 'Я')
                {
                    Console.WriteLine("Некоректный ввод");
                }

            } while (character.Length > 1 || (Convert.ToChar(character) < 'А' || Convert.ToChar(character) > 'Я'));

            return character;
        }
    }

    
}
