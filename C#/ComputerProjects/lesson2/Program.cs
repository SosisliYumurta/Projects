//OOP in C#
//version 0.1
using System;
using System.Collections.Generic;
class Computer
{
    private string _name;
    private string _ipaddress;
    private string _os;
    private bool _switchOn;
    private static int counter = 0;
    public Computer(string bn, string os)
    {
        Name = bn;
       // IPAddress = ip;
        OS = os;

        counter++;
    }

    public static int NumOfComp()
    {
        return counter;
    }
    public bool SwitchOn(String ip)
    {
        if (!SwitchOnp)
        {
            _switchOn = true;
            IPAddress = ip;
        }
        else
        {
            _switchOn = false;
            IPAddress = null;
        }
        
            return false;
    }
    
   

    public Computer() { }
    //proprties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string IPAddress
    {
        get { return _ipaddress; }
        set { _ipaddress = value; }
    }
    public string OS
    {
        get { return _os; }
        set { _os = value; }
    }
    public bool SwitchOnp
    {
        get { return _switchOn; }
        set { _switchOn = value; }
    }

}

class Program
{
    static string getNum(int limit)
    {
        Random random = new Random();
        int num;
        num = random.Next(1, limit);
        return num.ToString();
    }

    static void Main()
    {
        Computer comp01 = new Computer("alfa",  "Windows 10");
        Computer comp02 = new Computer("beta",  "Windows 10");
        Computer comp03 = new Computer("delta", "Ubuntu");
        Computer comp04 = new Computer();

        comp01.SwitchOn("10.0." + getNum(128) + "." + getNum(254));
        comp02.SwitchOn("10.0." + getNum(128) + "." + getNum(254));
        //comp03.SwitchOn("10.0." + getNum(128) + "." + getNum(254));


        List<Computer> net = new List<Computer>();
        net.Add(comp01);
        net.Add(comp02);
        net.Add(comp03);

        for (int i = 0; i < net.Count; i++)
        {
            Console.WriteLine(net[i].Name + " " + net[i].IPAddress);
        }

        comp02.SwitchOn("10.0." + getNum(128) + "." + getNum(254));
        
        for (int i = 0; i < net.Count; i++)
        {
            Console.WriteLine(net[i].Name + " " + net[i].IPAddress);
        }

        Console.WriteLine("We have {0} computers in our network.",Computer.NumOfComp());
    }
    
}
//inheritance