using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class Computer : IComputerService

    {
        public string Name { get; set; }
        public string OS { get; set; }
        public string IpAdress { get; set; }
        public bool SwitchOnOff { get; set; }


        public static int counterComp = 0;
        public static int isRunning = 0;
        public static int compInNet = 10;

        public Computer(string name, string oS, string ipAdress, bool switchOnOff)
        {
            Name = name;
            OS = oS;
            IpAdress = ipAdress;
            SwitchOnOff = switchOnOff;
            counterComp++;
        }
        public static int CountComp()
        {
            return counterComp;
        }
        public static int Running()
        {
            return isRunning;
        }
        public static void DisplayComputer(List<Computer> computers)
        {
            foreach (var c in computers)
            {

                Console.WriteLine("The Computer Name= {0}, Operating System= {1}, IpAddress= {2} and Statu= {3}", c.Name, c.OS, c.IpAdress, c.SwitchOnOff);

            }
        }
        public static void PingToComputer(List<Computer> computers, Computer computer, string ping)
        {
            Random rnd = new Random();
            bool found = false;
            Console.WriteLine("Trying to ping from the {0}({1}) to {2}", computer.Name, computer.IpAdress, ping);

            foreach (var c in computers)
            {
                if ((c.IpAdress == ping) && (c.SwitchOnOff == true))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("64 bytes from {0} icmp_seq={1} ttl=64 time={2} ms",
                        computer.IpAdress, i.ToString(), rnd.Next(1, 100) / 100);
                }
            }
            else
            {
                DateTime now = DateTime.Now;
                
                Console.WriteLine("The computer you are pinging cannot be found");
                ReportErrors("C:\\Users\\Casper\\Desktop\\error.txt", ("The computer you are pinging cannot be found "+now.ToString()));    
            }



        }
        public virtual void StartDevice()
        {
            this.SwitchOnOff = true;
            isRunning++;
            //this.GetIpAddress();
            Console.WriteLine("The Computer {0} is Starting", this.Name);

        }

        public virtual void ShutDownDevice()
        {
            this.SwitchOnOff = false;
            isRunning--;
            Console.WriteLine("The Computer {0} is shuting down !!!", this.Name);


        }
        //public string GetIpAddress()
        //{
        //    return "10.0.0." + (++compInNet).ToString();
        //}
        static public void ReportErrors(string fullPath, string errorMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fullPath))
                {

                    writer.WriteLine(errorMessage);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

}
