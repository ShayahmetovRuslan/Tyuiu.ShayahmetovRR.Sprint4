using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task1.V9.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task1.V9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #4 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #4                                                                  *");
			Console.WriteLine("* Тема: Обработка структурных типов                                           *");
			Console.WriteLine("* Задание #0                                                                 *");
			Console.WriteLine("* Вариант #16                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими *");
			Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать произведение четных элементов  *");
			Console.WriteLine("                                 массива.  {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}     ");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int len;
			Console.WriteLine("Введите длину списка: ");
			len = Convert.ToInt32(Console.ReadLine());

			int[] array = new int[len];
			Console.WriteLine("Введите значения списка: ");
			for (int i = 0; i < len; i++)
			{
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Результат: " + ds.Calculate(array));
			Console.ReadKey();
		}
	}
}
