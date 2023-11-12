using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint4.Task6.V17.Lib;


namespace Tyuiu.ShayahmetovRR.Sprint4.Task6.V17
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
			Console.WriteLine("* Задание #6                                                                 *");
			Console.WriteLine("* Вариант #17                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Посчитать элементы строки содержащие N символов                            *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Python, JavaScript, Java, C#, Swift, Kotlin, Ruby");
			var arr = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

			Console.WriteLine("\n \n******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine(ds.Calculate(arr));

			Console.ReadKey();
		}
	}
}
