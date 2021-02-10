using System;
using System.Collections.Generic;
using System.Text;

namespace Visilica
{
    class CheckingForErrors
    {
        public static string ErrorInOutputCharacter()
        {
            string character;

            do
            {
                character = Console.ReadLine().ToUpper();

                if (character.Length > 1)
                {
                    Console.WriteLine("Вы ввели больше 1 буквы");
                }
                else if (Convert.ToChar(character) < 'А' || Convert.ToChar(character) > 'Я')
                {
                    Console.WriteLine("Некоректный ввод");
                }

            } while (character.Length > 1 || (Convert.ToChar(character) < 'А' || Convert.ToChar(character) > 'Я'));

            return character;
        }

    }
}
