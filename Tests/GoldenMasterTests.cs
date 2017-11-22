using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace Tests
{
    public class GoldenMasterTests
    {
        [TestFixture]
        public class MazeConstruction_Random_0
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(0);
            }
            
            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }

        [TestFixture]
        public class MazeConstruction_Random_1
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(1);
            }

            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }

        [TestFixture]
        public class MazeConstruction_Random_2
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(2);
            }

            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                // TODO Bug: doesn't create solvable maze!
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }

        [TestFixture]
        public class MazeConstruction_Random_3
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(3);
            }

            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                // TODO Bug: doesn't create solvable maze!
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }

        [TestFixture]
        public class MazeConstruction_Random_4
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(4);
            }

            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                // TODO Bug: doesn't create solvable maze!
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }

        [TestFixture]
        public class MazeConstruction_Random_5
        {
            [SetUp]
            public void SetUp()
            {
                Amazing.random = new Random(5);
            }

            [Test]
            public void Horizontal_0_Vertical_0()
            {
                try
                {
                    Amazing.doit(0, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_0_Vertical_1()
            {
                try
                {
                    Amazing.doit(0, 1);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [Test]
            public void Horizontal_1_Vertical_0()
            {
                try
                {
                    Amazing.doit(1, 0);
                    Assert.Fail();
                }
                catch
                {
                    Assert.Pass();
                }
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_1_Vertical_1()
            {
                Amazing.doit(1, 1);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_2_Vertical_2()
            {
                // TODO Bug: doesn't create solvable maze!
                Amazing.doit(2, 2);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_3_Vertical_3()
            {
                Amazing.doit(3, 3);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_10()
            {
                Amazing.doit(10, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_10_Vertical_20()
            {
                Amazing.doit(10, 20);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_20_Vertical_10()
            {
                Amazing.doit(20, 10);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_25_Vertical_50()
            {
                Amazing.doit(25, 50);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_50_Vertical_25()
            {
                Amazing.doit(50, 25);
                var result = Amazing.result;
                Approvals.Verify(result);
            }

            [UseReporter(typeof(DiffReporter))]
            [Test]
            public void Horizontal_100_Vertical_100()
            {
                Amazing.doit(100, 100);
                var result = Amazing.result;
                Approvals.Verify(result);
            }
        }
    }
}