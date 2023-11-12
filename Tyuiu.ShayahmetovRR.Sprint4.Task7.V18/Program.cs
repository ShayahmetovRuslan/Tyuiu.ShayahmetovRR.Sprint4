using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task7.V18.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task7.V18
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
			Console.WriteLine("* Задание #7                                                                 *");
			Console.WriteLine("* Вариант #18                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Преобразовать строку в матрицу и посчитать произведение четных чисел       *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int index = 0;
			int rows = 5;
			int cols = 3;
			int[,] mtrx = new int[rows, cols];
			string str = "145258749635789";

			Console.WriteLine($"Строка: {str}");

			Console.WriteLine("\n \n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("\nМассив: ");
			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine("");
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{str[index]} ");
					index++;
				}
			}
			Console.WriteLine("\n\nПроизведение четных чисел: " + ds.Calculate(rows, cols, str));

			Console.ReadKey();
		}
	}
}
