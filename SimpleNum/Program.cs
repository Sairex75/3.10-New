using System;

namespace SimpleNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = 0;
            bool simpleNum = false;
            int countNum = 2;
            float remainder;

            Console.WriteLine("Введите целое число, чтобы узнать, простое оно или нет: ");

            userNum = int.Parse(Console.ReadLine());



            while (countNum < userNum - 1)
            {


                remainder = userNum % countNum;

                countNum += 1;

                if (remainder == 0)
                {
                    simpleNum = true;
                    break;
                }


            }

            if (simpleNum == false)
            {
                Console.WriteLine($"Число {userNum} простое\n");
            }
            else
            {
                Console.WriteLine($"Число {userNum} не простое\n");
            }

        }
    }
}
