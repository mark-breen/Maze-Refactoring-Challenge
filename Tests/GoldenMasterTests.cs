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
        public class Seed_0_Size_0_By_0
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(0);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Assert.Throws<IndexOutOfRangeException>(() => Amazing.CreateMaze(0, 0));
            }
        }

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_0_Size_0_By_1
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(0);
                Amazing.CreateMaze(0, 1);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_0_Size_1_By_0
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(0);
                Amazing.CreateMaze(1, 0);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_0_Size_1_By_1
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(0);
                Amazing.CreateMaze(1, 1);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }

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

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_1973_Size_3_By_5
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(1973);
                Amazing.CreateMaze(3, 5);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }

        [TestFixture]
        [UseReporter(typeof(DiffReporter))]
        public class Seed_2017_Size_100_By_100
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.Random = new Random(2017);
                Amazing.CreateMaze(100, 100);
            }

            [Test]
            public void AssertThatMazeIsCorrect()
            {
                Approvals.Verify(Amazing.Result);
            }
        }
    }
}