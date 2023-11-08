using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task2.V11.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task2.V11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			DataService ds = new DataService();
			Console.Title = "Спринт #4 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #4                                                                  *");
			Console.WriteLine("* Тема: Обработка структурных типов                                          *");
			Console.WriteLine("* Задание #2                                                                 *");
			Console.WriteLine("* Вариант #11                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Задать одномерный массив случайными числами, посчитать их сумму            *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int len;
			Console.WriteLine("Введите длину списка: ");
			len = Convert.ToInt32(Console.ReadLine());

			int[] array = new int[len];
			for (int i = 0; i < len; i++)
			{
				array[i] = rnd.Next(3, 8);
			}
			Console.Write("Массив: ");
			Console.WriteLine(string.Join(", ", array));

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Результат: " + ds.Calculate(array));
			Console.ReadKey();
		}
	}
}
