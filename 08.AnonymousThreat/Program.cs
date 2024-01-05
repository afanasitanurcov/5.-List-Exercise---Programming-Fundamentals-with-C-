using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
               List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "merge":
                        int startMergeIndex = int.Parse(command[1]);

                        int endMergeIndex = int.Parse(command[2]);

                        string concatenatedWords = string.Empty;

                        for (int i = startMergeIndex; i < endMergeIndex; i++)
                        {
                            concatenatedWords += list[i];
                            list.RemoveAt(i);
                        }
                        list.Insert(startMergeIndex, concatenatedWords);



                        break;

                    case "divide":

                        break;


                }
              



                input = Console.ReadLine();
            }



        }
    }
}
