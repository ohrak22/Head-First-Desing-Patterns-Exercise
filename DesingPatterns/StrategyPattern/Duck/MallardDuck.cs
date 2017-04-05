using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	class MallardDuck : Duck
	{
		public MallardDuck()
		{
			quackBehavior = new Quack();
			flyBehavior = new FlyWithWings();
		}

		public override void display()
		{
			Console.WriteLine("저는 물오리입니다.");
		}
	}
}
