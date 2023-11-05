using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint4.Task0.V16.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint4.Task0.V16.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetMultEvenArrEl()
		{
			DataService ds = new DataService();
			int[] ababsdf = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

			int res = ds.GetMultEvenArrEl(ababsdf);
			int wait = 3072;
			Assert.AreEqual(wait, res);	
		}
	}
}
