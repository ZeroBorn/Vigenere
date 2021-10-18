
using System;

namespace Encryption_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Console.Write("Введите текст: ");
            var inputText = Console.ReadLine();
            Console.Write("Введите ключ: ");
            var password = Console.ReadLine();
            var encryptedText = VigenereCipher.Encrypt(inputText, password);
            Console.WriteLine("Зашифрованное сообщение: "+ encryptedText);
            Console.WriteLine("Расшифрованное сообщение: "+ VigenereCipher.Decrypt(encryptedText, password));
            Console.ReadLine();

        }
    }
}
