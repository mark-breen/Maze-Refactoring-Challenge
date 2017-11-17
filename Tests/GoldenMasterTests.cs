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
        }
    }
}