﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	class HouseBlend : Beverage
	{
		public HouseBlend()
		{
			Description = "하우스 블렌드 커피";
		}

		public override double cost()
		{
			return .89;
		}
	}
}
