using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace chernovik
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string info = Console.ReadLine();

            while (info == "end")
            {
                string[] infoArray = info.Split();

                string firstName = infoArray[0];
                string lastName = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string town = infoArray[3];


                info = Console.ReadLine();
            }
           
        }
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }
        }
    }
}
          
           
            
        