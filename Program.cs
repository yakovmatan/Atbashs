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
