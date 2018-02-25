using System;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;

using NUnitAssert = NUnit.Framework.Assert;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Singleton;

namespace SingletonTest
{
	[TestClass]
	public class SingletonTest
	{
		[TestMethod]
		public void CreateInstance_TwoTime_OnlyOneInstanceShouldbeCreated()
		{
			//Arrange
			MarioGame player1;
			MarioGame player2;
			//Act
			player1 = MarioGame.GetInstance();
			player2 = MarioGame.GetInstance();
			//Assert
			Assert.AreEqual(player1, player2, "Both the instances are equal");
		}
	}
}
