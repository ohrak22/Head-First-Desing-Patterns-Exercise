using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	// 음료.
	abstract class Beverage
	{
		public virtual string Description { get; protected set; }
		public abstract double cost();
	}
}
