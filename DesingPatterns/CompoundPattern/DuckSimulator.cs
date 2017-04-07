using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
	class DuckSimulator
	{
		public void simulate(AbstractDuckFactory factory)
		{
			Quackable redhead = factory.createRedheadDuck();
			Quackable call = factory.createDuckCall();
			Quackable rubber = factory.createRubberDuck();
			Quackable goose = new GooseAdapter(new Goose());
			Console.WriteLine("Duck Simulator: With Composite - Flocks");

			Flock flockOfDucks = new Flock();

			flockOfDucks.add(redhead);
			flockOfDucks.add(call);
			flockOfDucks.add(rubber);
			flockOfDucks.add(goose);

			Flock flockOfMallards = new Flock();

			Quackable mallard1 = factory.createMallardDuck();
			Quackable mallard2 = factory.createMallardDuck();
			Quackable mallard3 = factory.createMallardDuck();
			Quackable mallard4 = factory.createMallardDuck();

			flockOfMallards.add(mallard1);
			flockOfMallards.add(mallard2);
			flockOfMallards.add(mallard3);
			flockOfMallards.add(mallard4);

			flockOfDucks.add(flockOfMallards);

			Console.WriteLine("Duck Simulator: Whole Flock Simulation");
			simulate(flockOfDucks);
			Console.WriteLine("Duck Simulator: Mallard Flock Simulation");
			simulate(flockOfMallards);

			Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times");
		}

		public void simulate()
		{
			Quackable mallard = new QuackCounter(new MallardDuck());
			Quackable redhead = new QuackCounter(new RedheadDuck());
			Quackable call = new QuackCounter(new DuckCall());
			Quackable rubber = new QuackCounter(new RubberDuck());
			Quackable goose = new GooseAdapter(new Goose());

			simulate(mallard);
			simulate(redhead);
			simulate(call);
			simulate(rubber);
			simulate(goose);

			Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times");
		}

		void simulate(Quackable duck)
		{
			duck.quack();
		}
	}
}
