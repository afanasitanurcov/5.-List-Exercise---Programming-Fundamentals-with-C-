using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[firstPlayer.Count - 1] == secondPlayer[secondPlayer.Count - 1])
                {
                    firstPlayer.RemoveAt(firstPlayer.Count - 1);
                    secondPlayer.RemoveAt(secondPlayer.Count - 1);
                }
                else if (firstPlayer[firstPlayer.Count - 1] > secondPlayer[secondPlayer.Count - 1])
                {
                    int firstPlayerCard = firstPlayer[firstPlayer.Count - 1];
                    int secondPlayerCard = secondPlayer[secondPlayer.Count - 1];
                    firstPlayer.RemoveAt(firstPlayer.Count - 1);
                    secondPlayer.RemoveAt(secondPlayer.Count - 1);
                    firstPlayer.Insert(0, secondPlayerCard);
                    firstPlayer.Insert(0, firstPlayerCard);

                }
                else if (secondPlayer[secondPlayer.Count - 1] > firstPlayer[firstPlayer.Count - 1])
                {
                    int firstPlayerCard = firstPlayer[firstPlayer.Count - 1];
                    int secondPlayerCard = secondPlayer[secondPlayer.Count - 1];
                    firstPlayer.RemoveAt(firstPlayer.Count - 1);
                    secondPlayer.RemoveAt(secondPlayer.Count - 1);
                    secondPlayer.Insert(0, firstPlayerCard);
                    secondPlayer.Insert(0, secondPlayerCard);
                }
            }

            if (firstPlayer.Count > secondPlayer.Count)
            {
                sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");

            }
            else if (secondPlayer.Count > firstPlayer.Count)
            {
                sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
