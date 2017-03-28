using System;
using Maze;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace Tests
{
	[TestFixture]
	public class AmazingTests
	{
		[Test]
		public void Seed0size15x20() 
		{
			const string expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
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

			Amazing.Random = new AmazingRandom(0);
			Amazing.CreateMaze(15, 20);

			Assert.AreEqual(expected, Amazing.Result, "Should have the maze that was expected");
		}

		[Test]
		public void Seed100size4x5() 
		{
			const string expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
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

			Amazing.Random = new AmazingRandom(100);
			Amazing.CreateMaze(4, 5);

			Assert.AreEqual(expected, Amazing.Result, "Should have the maze that was expected");
		}
	}
}
