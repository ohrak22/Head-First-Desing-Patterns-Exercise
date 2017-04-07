using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
	interface QuackObservable
	{
		void registerObserver(Observer observer);
		void notifyObservers();
	}
}
