using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCards = 0;
            int cardsSum = 0;
            int card;

            string cardStr;

            Console.WriteLine("Здравствуйте, сколько у вас карт в руке?");

            numberOfCards = int.Parse(Console.ReadLine());

            Console.WriteLine($"У вас в руке {numberOfCards} карт(ы).");

            for (int i = 0; i < numberOfCards; i++)
            {

                Console.WriteLine("Введите номинал карты или рубашку (T, J, Q, K): ");

                cardStr = Console.ReadLine();

                if (cardStr == "T" || cardStr == "J" || cardStr == "Q" || cardStr == "K")
                {
                    cardsSum += 10;
                }
                else
                {

                    card = int.Parse(cardStr);

                    switch (card)
                    {
                        case 2:
                            card = 2;
                            cardsSum = cardsSum + card;
                            break;
                        case 3:
                            card = 3;
                            cardsSum = cardsSum + card;
                            break;
                        case 4:
                            card = 4;
                            cardsSum = cardsSum + card;
                            break;
                        case 5:
                            card = 5;
                            cardsSum = cardsSum + card;
                            break;
                        case 6:
                            card = 6;
                            cardsSum = cardsSum + card;
                            break;
                        case 7:
                            card = 7;
                            cardsSum = cardsSum + card;
                            break;
                        case 8:
                            card = 8;
                            cardsSum = cardsSum + card;
                            break;
                        case 9:
                            card = 9;
                            cardsSum = cardsSum + card;
                            break;
                        case 10:
                            card = 10;
                            cardsSum = cardsSum + card;
                            break;

                        default:
                            Console.WriteLine("Нет такой карты!");
                            i = i - 1;
                            break;
                    }

                }
            }

            Console.WriteLine($"У вас в сумме {cardsSum} очков!\n\n");
        }
    }
}
