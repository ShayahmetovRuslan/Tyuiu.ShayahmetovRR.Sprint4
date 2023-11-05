using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint4.Task1.V9.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task1.V9.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalc()
		{
			DataService ds = new DataService();

			int[] array = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };

			int res = ds.Calculate(array);
			int wait = 21609;

			Assert.AreEqual(res, wait);
		}
	}
}
