using System;

namespace MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int newUserNums;
            int savedUserNums;
            int minUserNum = int.MaxValue;



            Console.WriteLine($"Введите размер последовательности цифр и я выберу наименьшее из них: ");
            newUserNums = int.Parse(Console.ReadLine());

            for (int i = 0; i < newUserNums; i++)
            {
                Console.WriteLine("Введите число: ");
                savedUserNums = int.Parse(Console.ReadLine());
                if (savedUserNums < minUserNum)
                {
                    minUserNum = savedUserNums;

                }

            }
            Console.WriteLine($"Минимальное введёное число {minUserNum}\n");
        }
    }
}
