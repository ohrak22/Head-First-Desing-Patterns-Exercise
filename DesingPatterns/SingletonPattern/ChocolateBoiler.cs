using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
	class ChocolateBoiler
	{
		private bool empty;
		private bool boiled;

		private static ChocolateBoiler uniqueInstance;

		private ChocolateBoiler()
		{
			empty = true;
			boiled = false;
		}

		public static ChocolateBoiler getInstance()
		{
			if(uniqueInstance == null)
			{
				uniqueInstance = new ChocolateBoiler();
			}
			return uniqueInstance;
		}


		public void fill()
		{
			if(isEmpty())
			{
				empty = false;
				boiled = false;
				Console.WriteLine("fill");
			}
		}
		
		public void boil()
		{
			if(!isEmpty() && !isBoiled())
			{
				boiled = true;
				Console.WriteLine("boil");
			}
		}

		public void drain()
		{
			if(!isEmpty() && isBoiled())
			{
				empty = true;
				Console.WriteLine("drain");
			}
		}

		public bool isEmpty()
		{
			return empty;
		}

		public bool isBoiled()
		{
			return boiled;
		}
	}
}
