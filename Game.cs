using System;
using System.Collections.Generic;
using System.Text;

namespace Visilica
{
    public class Game
    {
        public static string newWord { get; set; }
        private static List<string> characters { get; set; }
        private static string[] massiveInput { get; set; }

        private static string tryes = "7";
        public static void Shifr()
        {
            characters = new List<string>();

            foreach (var i in newWord)
                characters.Add(i.ToString());

            massiveInput = new string[characters.Count];

            for (int i = 0; i < massiveInput.Length; i++)
                massiveInput[i] = "-";

        }
        public static void WriteGame()
        {
            foreach (var i in massiveInput)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine(tryes);
        }
        public static void ReadCharacter(string bukv)
        {
            if (characters.Contains(bukv))
            {
                TrueCharacter(bukv);
            }
            else
            {
                tryes = (int.Parse(tryes) - 1).ToString();
            }
        }
        private static void TrueCharacter(string bukv)
        {
            int ind = characters.IndexOf(bukv);

            massiveInput[ind] = bukv;

            characters[ind] = "*";

            if (characters.Contains(bukv))
            {
                TrueCharacter(bukv);
            }
            else
                return;

        }
        public static bool ChekingForEnd()
        {
            int numberOfEmptyFields = 0;

            foreach (var i in massiveInput)
            {
                if (i == "-")
                {
                    numberOfEmptyFields++;
                }
            }

            if (numberOfEmptyFields > 0)
                return false;
            else
                return true;

        }

    }
}
