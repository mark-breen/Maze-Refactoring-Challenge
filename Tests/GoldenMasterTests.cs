using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Maze;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace Tests
{
    public class GoldenMasterTests
    {
        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_0_Size_15_By_20
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(0);
                Amazing.CreateMaze(15, 20);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_100_Size_4_By_5
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(100);
                Amazing.CreateMaze(4, 5);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }
    }
}