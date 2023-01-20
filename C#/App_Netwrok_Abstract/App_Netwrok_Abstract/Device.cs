using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Netwrok_Abstract
{
	public abstract class Device
	{
		public Device(string name, string make)
		{
			_name = name;
			_make = make;
		}

		protected string _name;
		protected string _make;
		public abstract void StartDevice();
		public abstract void ShutDown();

	}
}
