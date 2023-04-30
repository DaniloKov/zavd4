using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть речення: ");
            string sentence = Console.ReadLine();

           //отриманий тест розбиваємо і додаємо в лист
            string[] words = sentence.ToLower().Split(' ', '.', ',');
           List<string> TEXT = new List<string>();
            foreach (string word in words)
            {
                TEXT.Add(word);
            }


            //робимо перевірку всередині листа
            for (int i = 0;i< TEXT.Count;i++)
            {
             
                int n = 0;
                for (int j=i+1;j<TEXT.Count;j++)
                {
                    if (TEXT[i] == TEXT[j]) {
                    TEXT.RemoveAt(j);
                        j--;
                        n++;
                       
                    }
                }

                if (n > 0)
                {
                    TEXT.RemoveAt(i);
                    i--;
                }
            }

            //виводимо
            Console.WriteLine("Слова якi не повторювались нi разу: ");
            foreach (string word in TEXT)
            {
                Console.WriteLine(word);
            }


            Console.ReadLine();
        }
    }
}
