using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint4.Task2.V11.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task2.V11.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalculate()
		{
			DataService ds = new DataService();

			int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

			int res = ds.Calculate(array);
			int wait = 15;

			Assert.AreEqual(wait, res);
		}
	}
}
