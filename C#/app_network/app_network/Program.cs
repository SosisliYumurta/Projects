using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerLibrary;

namespace app_network
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> network = new List<Computer>();

            Computer alfa = new Computer("Alfa", "Windows", "10.10.10",false);
            Computer beta = new Computer("Beta", "Pardus", "10.10.11",false);
            Computer omega = new Computer("Omega", "Ubuntu", "10.10.12",false);
            Computer teta = new Computer("Teta", "Linux", "10.10.13",false);
           // Computer.PingToComputer(network, beta, "10.10.12");

            network.Add(alfa);
            network.Add(beta);
            network.Add(omega);
            network.Add(teta);
            Console.WriteLine(Computer.CountComp());
            Console.WriteLine(Computer.Running());
            

            Computer.DisplayComputer(network);
            

            foreach (var c in network)
            {
                c.StartDevice();
            }
            Console.WriteLine("--------------------------------");
            Computer.DisplayComputer(network);
            Console.WriteLine(Computer.Running());

            alfa.ShutDownDevice();
            Console.WriteLine("--------------------------------");
            Computer.DisplayComputer(network);
            Console.WriteLine(Computer.CountComp());
            Console.WriteLine(Computer.Running());

            Computer.PingToComputer(network, beta, "10.10.13");





            Console.ReadLine();
        }
    }
}
