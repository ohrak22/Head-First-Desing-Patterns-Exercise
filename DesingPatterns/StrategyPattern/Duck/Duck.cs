using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	abstract class Duck
	{
		public FlyBehavior flyBehavior { protected get;  set; }
		public QuackBehavior quackBehavior { protected get; set; }

		public abstract void display();
		
		public void performFly()
		{
			flyBehavior.fly();
		}

		public void performQuack()
		{
			quackBehavior.quack();
		}

		public void swim()
		{
			Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠");
		}
	}
}
