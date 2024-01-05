using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<string> list = Console.ReadLine().Split().ToList();


            string str = Console.ReadLine();
            List<char> charList = str.ToCharArray().ToList();
            List<string> list = new List<string>();
            charList.ForEach(c => list.Add(c.ToString()));
            list.RemoveAll(x => x == " ");
                     

            List<string> result = new List<string>();

            while (list.Any(x => x == "|"))
            {

                int cherta = list.LastIndexOf("|");

                
                    for (int i = cherta + 1; i < list.Count; i++)
                    {
                        result.Add(list[i]);
                    }
                
                    for (int i = list.Count - 1;i >= cherta;i--)
                    {
                    list.RemoveAt(i);
                    }

            }
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i]);

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
