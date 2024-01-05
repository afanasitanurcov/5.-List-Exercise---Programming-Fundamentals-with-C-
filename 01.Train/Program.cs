using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine(string.Join(" ", train));
                    return;
                }
                string[] arrayComand = command.Split().ToArray();

                if (arrayComand[0] == "Add")
                {
                    int additionalWagon = int.Parse(arrayComand[1]);

                    train.Add(additionalWagon);

                }
                else
                {
                    int currentPeople = int.Parse(arrayComand[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + currentPeople <= wagonCapacity) 
                        {
                            train[i] += currentPeople;
                            break;
                        }

                    }


                }

            }
        }
    }
}
