using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_HomeWork
{
    class Program
    {
        static string[] SplitText(string EnterTextLine)
        {
            string[] Words = EnterTextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Words;
        }

        static void PrintWords(string[] EnterWords)
        {
            foreach (string Word in EnterWords)
            {
                Console.WriteLine(Word);
            }
        }

        //программа разделяет предложение на слова и выводит слова с новой строки
        static void Main(string[] args)
        {
            Console.Write("Напишите предложение, каждое слово отделите пробелом: ");
            string TextLine = Console.ReadLine();

            string[] Words = SplitText(TextLine);

            PrintWords(Words);

            Console.ReadLine();
        }
    }
}
