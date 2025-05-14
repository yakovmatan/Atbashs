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

        static void test(string[] str ,int s)
        {
            Console.WriteLine(string.Join(" ",str));
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string originalMessage = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.\r\n";
            string[] decryptedMessage = Decrypted(originalMessage);
            string[] dangerWords = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            int dangerPoints = DangerLevel(decryptedMessage, dangerWords);
            test(decryptedMessage, dangerPoints);
        }
    }
}
