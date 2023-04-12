using System;

namespace KnowTheNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int knowTheNumberUserMaxNumber;
            int knowTheNumberUserNumber;
            int count = 0;


            Console.WriteLine("Давайте поиграем в игру: Угадай число! Для начала выберите максимальное число от 0 которое может быть в игре!");
            knowTheNumberUserMaxNumber = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();
            int randomNumberInGame = randomNumber.Next(0, knowTheNumberUserMaxNumber);




            while (true)
            {
                count++;

                Console.WriteLine("Введите предполагаемое число! Или если устали, введите 0 Чтобы выйти =)");

                knowTheNumberUserNumber = int.Parse(Console.ReadLine());

                if (knowTheNumberUserNumber < randomNumberInGame)
                {
                    Console.WriteLine("Введённое число меньше загаданного, попробуйте ещё раз.");
                }
                else if (knowTheNumberUserNumber > randomNumberInGame)
                {
                    Console.WriteLine("Введённое число больше загаданного, попробуйте ещё раз.");
                }
                else if (knowTheNumberUserNumber == 0)
                {
                    Console.WriteLine("Спасибо что сыграли, возвращайтесь если захотите ещё раз!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Число угадано. Число попыток {count}.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
