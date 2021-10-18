using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Machine
{
    public class VigenereCipher
    {
        static string Library = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //ABCDEFGHIJKLMNOPQRSTUVWXYZ           abcdefghijklmnopqrstuvwxyz          АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ

        public static string Key(string text, int n)
        {
            string str = text;
            while (str.Length < n)
            {
                str += str;
            }

            return str.Substring(0, n);
        }

        public static string Vigenere(string text,string pas,bool encrypting = true)
        {
            var key = Key(pas, text.Length);
            var exit = "";
            var counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var libIndex = Library.IndexOf(text[i]);
                var codeIndex = Library.IndexOf(key[(i - counter) % key.Length]);
               
                if (libIndex < 0)
                {
                    exit += text[i].ToString();
                    counter++;
                }
                else
                {
                    exit += Library[((Library.Length + libIndex + ((encrypting ? 1 : -1) * codeIndex)) % Library.Length)].ToString();
                }
            }
            return exit;
        }

        public static string Encrypt(string Messag, string password)
        {          
        return Vigenere(Messag, password);
        }
        
        public static string Decrypt(string encryptedMes, string password)
        {
        return Vigenere(encryptedMes, password, false);
        }

    }

}

