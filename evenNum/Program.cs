using System;

namespace evenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;

            Console.WriteLine("Введите целое число, чтобы узнать, чётное оно или не чётное: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"Число {userNumber} чётное!\n");
            }
            else
            {
                Console.WriteLine($"Число {userNumber} не чётное!\n");
            }
        }
    }
}
