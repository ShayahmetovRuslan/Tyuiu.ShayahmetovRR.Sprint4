using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task1.V9.Lib
{
	public class DataService : ISprint4Task1V9
	{
		int p = 1;
		public int Calculate(int[] array)
		{
			for (int i = 2; i < 8; i++)
			{
				p *= array[i];
			}
			return p;
		}
	}
}
