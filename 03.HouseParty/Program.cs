using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                    string name = command[0];
                if (command.Count == 3)
                {
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }
                }
                else if (command.Count == 4)
                {
                    if (!list.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    list.Remove(name);
                }               


            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
