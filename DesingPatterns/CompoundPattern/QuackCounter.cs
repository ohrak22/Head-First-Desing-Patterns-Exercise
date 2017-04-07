﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
	class QuackCounter : Quackable
	{
		Quackable duck;
		static int numberOfQuacks;

		public QuackCounter(Quackable duck)
		{
			this.duck = duck;
		}

		public void quack()
		{
			duck.quack();
			numberOfQuacks++;
		}

		public static int getQuacks()
		{
			return numberOfQuacks;
		}
	}
}
