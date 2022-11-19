using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerIntro
{
    class Computer
    {
        private String name;
        private String oSystem;
        private String ipAdress;
        private bool switchOnOff;
        
        private static int counter = 0;

        public Computer(string name, string oSystem, string ipAdress)
        {
            this.name = name;
            this.oSystem = oSystem;
            this.ipAdress = ipAdress;

            counter++;
        }
        public static int NumberOfComputer()
        {
            return counter;
            
        }
        public static void PrintComputers(List<Computer> computers)
        {
            foreach (var c in computers)
            {
                Console.WriteLine("Computer name= {0}, Computer Operating System= {1}, Computer Ip Adress= {2}",c.Name,c.Osystem,c.IpAdress);
            }
        }
        public bool SwitchOnOff
        {
            get { return switchOnOff; }
            set { switchOnOff = value; }
        }
        public String Osystem
        {
            get { return oSystem; }
            set { oSystem = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String IpAdress
        {
            get { return ipAdress; }
            set { ipAdress = value; }
        }
    }
}
