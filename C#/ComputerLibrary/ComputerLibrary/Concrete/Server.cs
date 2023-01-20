using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    class Server : Computer
    {
        public Server(string name, string os, string ipAdress, bool switchOnOff) : base(name,os,ipAdress,switchOnOff)
        {

        }
        public override void StartDevice()
        {
            this.SwitchOnOff = true;
            isRunning++;
            //this.GetIpAddress();
            Console.WriteLine("The Computer {0} is Starting", this.Name);

        }

        public override void ShutDownDevice()
        {
            Console.WriteLine("************* !!! **************** ");
            Console.Write("You want to shut dowm this server. Are you sure ? (YES/n): ");


            string confirm = Console.ReadLine();
            if (confirm == "YES")
            {
                this.SwitchOnOff = false;
                isRunning--;
                Console.WriteLine("The comp {0} is shuting down !!!", this.Name);
            }

        }
    }
}
