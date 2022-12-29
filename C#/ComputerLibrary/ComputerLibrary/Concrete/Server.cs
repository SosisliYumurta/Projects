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
    }
}
