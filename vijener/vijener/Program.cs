using System;

namespace vijener
{
    class Program
    {

        static void Main(string[] args)
        {
            VigenereCipher cipher = new VigenereCipher();
            Console.Write("Ввъведете текст, който да бъде шифриран: ");
            var inputText = Console.ReadLine().ToUpper();
            Console.Write("Въведете ключ за шифрирания текст: ");
            var password = Console.ReadLine().ToUpper();
            Console.WriteLine("Въведете индекса на желаната операция");
            Console.WriteLine("1. Шифриране");
            Console.WriteLine("2. Дешифриране");
            var operaion = Console.ReadLine();
            if (operaion == "1")
                Console.WriteLine("Шифрирано съобщение: {0}", cipher.SolveVigenere(inputText, password, true));
            else
                if (operaion == "2")
                Console.WriteLine("Дешифрирано съобщение: {0}", cipher.SolveVigenere(inputText, password, false));
            else
                Console.WriteLine("Избрали сте невалидна операция!");

        }
    }
}

