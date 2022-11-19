using System;
using System.Collections.Generic;

namespace ComputerIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer("Alfa","linux","10.50.255");
            Computer computer2 = new Computer("Beta","Pardus","10.50.256");
            Computer computer3 = new Computer("Teta","Windows","10.50.257");

            Console.WriteLine("Total Number Of Computers= "+Computer.NumberOfComputer());

            List<Computer> computerList = new List<Computer>();

            computerList.Add(computer1);
            computerList.Add(computer2);
            computerList.Add(computer3);

            Computer.PrintComputers(computerList);

            Server s1 = new Server("a", "b", "c", "qwe");
            Console.WriteLine(s1.Name+s1.Destination);



        }
    }
}
