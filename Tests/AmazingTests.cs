using System;
using NUnit.Framework;
using Tests.GoldenMasters;
using Tests.Helpers;

namespace Tests
{
	[TestFixture]
	public class AmazingTests
	{
		[Test]
		public void Seed0Size15X20() 
		{
			String expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:--:--:--:--:--:--:--:  :--:--:--:--:
I                             I        I     I 
:  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:
I           I     I     I  I     I     I     I 
:--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :
I        I  I  I     I  I     I     I     I  I 
:--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :
I     I  I     I     I     I  I           I  I 
:  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :
I  I  I     I        I     I  I     I     I  I 
:  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :
I  I  I     I  I     I        I     I  I  I  I 
:  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :
I  I     I     I  I  I        I  I     I  I  I 
:  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :
I  I  I     I     I  I     I  I  I        I  I 
:  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :
I           I  I     I  I  I     I     I  I  I 
:--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :
I     I  I        I     I  I  I        I     I 
:  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:
I  I  I     I  I     I     I  I        I     I 
:--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :
I     I  I     I        I     I  I     I  I  I 
:  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :
I        I  I     I     I     I  I        I  I 
:  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :
I        I     I     I     I  I  I     I     I 
:--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :
I     I     I  I  I  I     I     I  I        I 
:  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:
I  I        I     I  I           I  I  I     I 
:  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :
I  I        I  I  I     I     I  I           I 
:  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:
I     I  I  I     I  I  I           I        I 
:--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:
I     I  I     I     I              I        I 
:  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :
I                 I  I     I     I           I 
:--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:
";
			Assert.AreEqual(expected, AmazingWrapper.GetMazeFor(new AmazingTestScenario(0, 15, 20)), "Should have the maze that was expected");
		}

		[Test]
		public void Seed100Size4X5() 
		{
			String expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:  :
I           I 
:  :--:  :--:
I     I  I  I 
:--:  :  :  :
I  I  I     I 
:  :  :--:  :
I  I     I  I 
:  :--:  :  :
I        I  I 
:--:--:--:  :
";
			Assert.AreEqual(expected, AmazingWrapper.GetMazeFor(new AmazingTestScenario(100, 4, 5)), "Should have the maze that was expected");
		}
	}
}
