using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                switch (command[0])
                {
                    case "End":
                        Console.WriteLine(string.Join(" ", list));
                        return;

                    case "Add":
                        list = AddElement(list, command);
                        break;

                    case "Remove":
                        list = RemoveElement(list, command);
                        break;

                    case "Shift":
                        list = ShiftElements(list, command);
                        break;

                    case "Insert":
                        list = Insert(list, command);

                        break; 
                }
            }

            //}
            static List<int> AddElement(List<int> list, List<string> command)
            {
                int currentNumber = int.Parse(command[1]);

                list.Add(currentNumber);

                return list;
            }


            static List<int> RemoveElement(List<int> list, List<string> command)
            {
                int currentIndex = int.Parse(command[1]);

                if (currentIndex <= list.Count - 1 && currentIndex >= 0)
                {
                    list.RemoveAt(currentIndex);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
                return list;
            }

            static List<int> ShiftElements(List<int> list, List<string> command)
            {
                int amount = 0;
                switch (command[1])
                {
                    case "left":
                        amount = int.Parse(command[2]);

                        for (int i = 0; i < amount; i++)
                        {
                            int firstNum = list[0];
                            list.RemoveAt(0);
                            list.Add(firstNum);

                        }

                        break;


                    case "right":

                        amount = int.Parse(command[2]);
                        for (int i = 0; i < amount; i++)
                        {
                            int lastNum = list[list.Count - 1];
                            list.RemoveAt(list.Count - 1);
                            list.Insert(0, lastNum);
                        }

                        break;

                }

                return list;
            }

            static List<int> Insert(List<int> list, List<string> command)
            {
                int number = int.Parse(command[1]);
                int index = int.Parse(command[2]);
                if (index <= list.Count - 1 && index >= 0)
                {
                    list.Insert(index, number);
                }
                else
                {
                    Console.WriteLine("Invalid index");

                }
                return list;
            }

        }
    }
}









