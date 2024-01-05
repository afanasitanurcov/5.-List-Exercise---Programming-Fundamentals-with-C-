using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }

                string[] arrayCommand = command.Split().ToArray();

                switch(arrayCommand[0])
                {
                    case "Delete":
                        int currentElementDel = int.Parse(arrayCommand[1]);
                        numbers.RemoveAll(x => x == currentElementDel);
                        break;


                    case "Insert":
                        int currentElementIns = int.Parse(arrayCommand[1]);
                        int currentIndexIns = int.Parse(arrayCommand[2]);
                        numbers.Insert(currentIndexIns, currentElementIns);
                        break;
                }
            }
        }
    }
}
