using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	class ModelDuck : Duck
	{
		public ModelDuck()
		{
			flyBehavior = new FlyNoWay();
			quackBehavior = new Quack();
		}

		public override void display()
		{
			Console.WriteLine("I'm Model Duck");
		}
	}
}
