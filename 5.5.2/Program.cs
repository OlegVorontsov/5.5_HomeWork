using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5._5._2
{
    class Program
    {
        //метод смены порядка слов в предложении на противоположный
        static string ReversWords(string inputPhrase)
        {
            string[] Words = Reverse(inputPhrase);

            string outputPhrase = "";

            for (int i = Words.GetLength(0) - 1; i >= 0; i--)
            {
                outputPhrase += Words[i] + " ";
            }
            return outputPhrase;
        }

        //метод разделения предложенния на слова
        static string[] Reverse(string text)
        {
            string[] Words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Words;
        }
        static void Main(string[] args)
        {
            Console.Write("Напишите предложение, каждое слово отделите пробелом: ");
            string inputPhrase = Console.ReadLine();

            string reversePhrase = ReversWords(inputPhrase);
            Console.Write("Ваше предложение наоборот: {0}", reversePhrase);

            Thread.Sleep(7000);
        }
    }
}
