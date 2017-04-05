using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck mallard = new MallardDuck();
			mallard.performQuack();
			mallard.performFly();

			Duck model = new ModelDuck();
			model.performFly();
			model.flyBehavior = new FlyRocketPowered();
			model.performFly();
		}
	}
}
