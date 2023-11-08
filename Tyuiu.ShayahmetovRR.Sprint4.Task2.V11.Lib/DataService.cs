using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task2.V11.Lib
{
	public class DataService : ISprint4Task2V11
	{
		public int Calculate(int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}
	}
}
