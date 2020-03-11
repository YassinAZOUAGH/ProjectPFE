using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');
            System.Console.WriteLine("ici c'est : " + words[0] + "   " + words[1]);

           /* foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");

                System.Console.WriteLine("ici c'est : "+ words[0] + "   "+ words[1]);
            }*/
        }
    }
}
