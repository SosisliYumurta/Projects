using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerIntro
{
    class Server : Computer
    {
        private String destination;

        public Server(string name, string oSystem, string ipAdress, string destination)
            : base(name, oSystem, ipAdress)
        {
            this.destination = destination;
        }


        public String Destination
        {
            get { return destination; }
            set { destination = value; }
        }

    }
}
