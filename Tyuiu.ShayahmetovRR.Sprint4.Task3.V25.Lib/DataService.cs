using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task3.V25.Lib
{
	public class DataService : ISprint4Task3V25
	{
		public int Calculate(int[,] matrix)
		{
			int rows = matrix.GetUpperBound(0) + 1;
			int columns = matrix.Length / rows;

			int p = 1;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					p = matrix[0, 3] * matrix[1, 3] * matrix[2, 3] * matrix[3, 3] * matrix[4, 3];
				}
			}
			return p;
		}
	}
}
