using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atbashs
{
    internal class Program
    {
        static string[] Decrypted(string message)
        {
            string decrypted = "";
            Dictionary<char, char> atbash = new Dictionary<char, char>()
            {
                {'a', 'z'},
                {'b', 'y'},
                {'c', 'x'},
                {'d', 'w'},
                {'e', 'v'},
                {'f', 'u'},
                {'g', 't'},
                {'h', 's'},
                {'i', 'r'},
                {'j', 'q'},
                {'k', 'p'},
                {'l', 'o'},
                {'m', 'n'},
                {'n', 'm'},
                {'o', 'l'},
                {'p', 'k'},
                {'q', 'j'},
                {'r', 'i'},
                {'s', 'h'},
                {'t', 'g'},
                {'u', 'f'},
                {'v', 'e'},
                {'w', 'd'},
                {'x', 'c'},
                {'y', 'b'},
                {'z', 'a'}
            };
            foreach (char c in message)
            {
                if (atbash.ContainsKey(char.ToLower(c)))
                {
                    if (char.IsUpper(c))
                    {
                        decrypted += char.ToUpper(atbash[char.ToLower(c)]);
                    }
                    else
                    {
                        decrypted += atbash[c];
                    }
                    
                }
                else
                {
                    decrypted += c;
                }
            }
            string[] decryptedArray = decrypted.Split(' ');
            return decryptedArray;

        }

        static int DangerLevel(string[] DecryptedText, string[] WordsToFind)
        {
            int total = 0;
            foreach (string word in DecryptedText)
            {
                if (WordsToFind.Contains(word))
                {
                    total += 1;
                }
            }
            return total;
        }
        static void Main(string[] args)
        {
        }
    }
}
