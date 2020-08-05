using System;
using FindAndReplace.Models;
namespace FindAndReplace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give me a sentence.");
            string sentence = Console.ReadLine();
            Console.WriteLine("Give me a word to find.");
            string find = Console.ReadLine();
            Console.WriteLine("Give me a word to replace.");
            string replace = Console.ReadLine();
            string result = Replacer.Replace(sentence, find, replace);
            string result2 = Replacer.Replace2(sentence, find, replace);
            Console.WriteLine("Your answer with whole word matches is: " + result);
            Console.WriteLine("Your answer with partial word matches is: " + result2);
        }
    }
}