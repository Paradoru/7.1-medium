using System;

namespace _7._1_средний_уровень
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 0;
                char nik = 'k';
                Console.WriteLine("Введите текст");
                string text = Console.ReadLine();
                string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (char chacha in words[words.Length - 1])
                {
                    if (chacha == nik) count++;
                }
                Console.WriteLine("Букв k в последнем слове {0}", count);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
