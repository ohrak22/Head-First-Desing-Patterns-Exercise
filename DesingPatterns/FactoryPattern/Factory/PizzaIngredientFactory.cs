using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	interface PizzaIngredientFactory
	{
		Dough createDough();
		Sauce createSauce();
		Cheese createCheese();
		Veggies[] createVeggies();
		Pepperoni createPepperoni();
		Clam createClam();

	}

	public class Dough
	{
	}

	public class Sauce
	{
	}

	public class Cheese
	{
	}

	public class Veggies
	{
	}

	public class Pepperoni
	{
	}

	public class Clam
	{
	}

	public class ThinCrustDough : Dough
	{
	}

	public class MarinaraSauce : Sauce
	{
	}

	public class ReggianoCheese : Cheese
	{
	}

	public class Garlic : Veggies
	{
	}
	public class Onion : Veggies
	{
	}
	public class Mushroom : Veggies
	{
	}
	public class RedPepper : Veggies
	{
	}

	public class SlicedPepperoni : Pepperoni
	{
	}

	public class FreshClam : Clam
	{
	}
}
