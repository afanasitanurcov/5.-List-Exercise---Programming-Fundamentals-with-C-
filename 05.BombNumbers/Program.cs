using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> bombCharacteristic = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int bomb = bombCharacteristic[0];
            int bombPower = bombCharacteristic[1];
            int bombIndex = 0;


            for (int i = 0; i < list.Count; i++)
            {
                if (i >= list.Count)
                {
                    break;
                }
                bombIndex = list.FindIndex(x => x == bomb);

                if (list.Any(x => x == bomb))
                {
                    for (int j = 0; j <= bombPower && bombIndex < list.Count; j++)
                    {

                        if (bombIndex > list.Count - 1 && bombIndex < 0)
                        {
                            break;
                        }
                        list.RemoveAt(bombIndex);

                    }

                    for (int k = 0; k < bombPower && bombIndex-k > 0; k++)
                    {
                        if (bombIndex < 0 && bombIndex > list.Count - 1)
                        {
                            break;
                        }
                        list.RemoveAt(bombIndex - k - 1);
                    }
                }
                

            }
            int sum = list.Sum(x => x);
            //Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(sum);
        }
    }
}
