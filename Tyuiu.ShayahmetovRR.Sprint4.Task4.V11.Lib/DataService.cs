using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task4.V11.Lib
{
	public class DataService : ISprint4Task4V11
	{
		public int Calculate(int[,] matrix)
		{
			int rows = matrix.GetUpperBound(0) + 1;
			int columns = matrix.Length / rows;
			int sum = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (matrix[i, j] % 2 == 1)
					{
						sum += matrix[i, j];
					}
				}
			}
			return sum;
		}
	}
}
