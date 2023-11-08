using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task3.V25.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task3.V25
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #4 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #4                                                                  *");
			Console.WriteLine("* Тема: Обработка структурных типов                                          *");
			Console.WriteLine("* Задание #3                                                                 *");
			Console.WriteLine("* Вариант #25                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Посчитать элементы 4-го столбца двумерного массива                         *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int[,] mtrx = new int[5, 5] { { 7, 3, 5, 3, 6 },
										  {4, 6 ,2, 5, 7},
										  {2, 3, 3, 3, 5},
										  {2, 7, 7, 6, 2},
										  {6, 6, 4, 3, 6} };

			Console.WriteLine("Массив: ");
			for (int i = 0; i < mtrx.GetLength(0); i++)
			{
				Console.Write("\n");
				for (int j = 0; j < mtrx.GetLength(1); j++)
				{
					Console.Write($"{mtrx[i, j]} ");
				}
			}
			Console.WriteLine("\n \n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine(ds.Calculate(mtrx));
			Console.ReadKey();
		}
	}
}
