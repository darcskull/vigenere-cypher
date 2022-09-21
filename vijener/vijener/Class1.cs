using System;
using System.Collections.Generic;
using System.Text;

namespace vijener
{
    class VigenereCipher
    {
        string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦШЩЪЬЮЯ";

        //Приравняване на дължината на ключа с тази на съобщението
        private string CreateKey(string password, int length)
        {
            var pass = password;
            while (pass.Length < length)
            {
                //докато дължината на ключа е по-малка от тази на съобщението добавяме буквите на ключа, за да получим равна дължина
                pass += pass;
            }
            // премахваме излишните букви от ключа до дължината на съобщението
            return pass.Substring(0, length);
        }

        public string SolveVigenere(string message, string password, bool operation)
        {
            var key = CreateKey(password, message.Length);
            var solution = "";
            var length = alphabet.Length;

            for (int i = 0; i < message.Length; i++)
            {
                // взимаме индекса на буквата от съобщението
                var letterIndex = alphabet.IndexOf(message[i]);
                // взимаме индекса на буквата от ключа
                var keyIndex = alphabet.IndexOf(key[i]);
                if (letterIndex < 0)
                {
                    //Ако текстът не бъде намерен се добавя в оригинален вид
                    solution += message[i].ToString();
                }
                else
                {
                    // записваме буквата на позицията която съотвества на:
                    // (броят на буквите в азбуката + индексът на буквата от съобщениеето + индексът на буквата от ключа (- ако операцията е дешифриране)) % броят на буквите в азбуката
                    solution += alphabet[(length + letterIndex + ((operation ? 1 : -1) * keyIndex)) % length].ToString();
                }
            }

            if (solution == message)
                Console.WriteLine("Моля използвайте българската азбука за съобщението и ключа");

            return solution;
        }
    }
}
