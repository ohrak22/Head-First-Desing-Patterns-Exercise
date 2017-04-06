using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			MallardDuck duck = new MallardDuck();
			WildTurkey turkey = new WildTurkey();
			Duck turkeyAdapter = new TurkeyAdapter(turkey);

			Console.WriteLine("The Turkey Says...");
			turkey.gobble();
			turkey.fly();

			Console.WriteLine("The Duck Says...");
			duck.quack();
			duck.fly();

			Console.WriteLine("The TurkeyAdapter Says...");
			turkeyAdapter.quack();
			turkeyAdapter.fly();
		}
	}
}
