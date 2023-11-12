using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task4.V11.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task4.V11
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
			Console.WriteLine("* Задание #4                                                                 *");
			Console.WriteLine("* Вариант #11                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Сложить все нечетные элементы массива                                      *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int[,] mtrx = new int[5, 5];	

			for (int i = 0; i < mtrx.GetLength(0); i++)
			{
				for (int j = 0; j < mtrx.GetLength(1); j++)
				{
					Console.Write($"Введите {i}, {j} элемент массива: ");
					mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

				}
			}

			Console.WriteLine("Массив: ");
			for (int i = 0; i < mtrx.GetLength(0); i++)
			{
				Console.Write("\n");
				for (int j = 0; j < mtrx.GetLength(1); j++)
				{
					Console.Write($" {mtrx[i, j]} ");
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
