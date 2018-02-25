using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			MarioGame mg = MarioGame.GetInstance();
			Assert.AreEqual("", "");
		}
	}
}
