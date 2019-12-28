using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using NUnit.Framework;
using Tests.Helpers;

namespace Tests.GoldenMasters
{
    internal class GoldenMasterTests
    {
        private static IEnumerable<AmazingTestScenario> InvalidMazes
        {
            get
            {
                yield return new AmazingTestScenario(0, 0, 0);
                yield return new AmazingTestScenario(0, 0, 1);
                yield return new AmazingTestScenario(0, 1, 0);
            }
        }
        
        private static IEnumerable<AmazingTestScenario> ValidMazes
        {
            get
            {
                yield return new AmazingTestScenario(0,1, 1);
                yield return new AmazingTestScenario(0,5, 20);
                yield return new AmazingTestScenario(0,10, 20);
                yield return new AmazingTestScenario(0,15, 20);
                yield return new AmazingTestScenario(0,20, 20);
                yield return new AmazingTestScenario(0,40, 40);
                yield return new AmazingTestScenario(0,80, 80);
                yield return new AmazingTestScenario(0,160,160);
                
                yield return new AmazingTestScenario(1,1, 1);
                yield return new AmazingTestScenario(1,5, 20);
                yield return new AmazingTestScenario(1,10, 20);
                yield return new AmazingTestScenario(1,15, 20);
                yield return new AmazingTestScenario(1,20, 20);
                yield return new AmazingTestScenario(1,40, 40);
                yield return new AmazingTestScenario(1,80, 80);
                yield return new AmazingTestScenario(1,160,160);
                
                yield return new AmazingTestScenario(10,1, 1);
                yield return new AmazingTestScenario(10,5, 20);
                yield return new AmazingTestScenario(10,10, 20);
                yield return new AmazingTestScenario(10,15, 20);
                yield return new AmazingTestScenario(10,20, 20);
                yield return new AmazingTestScenario(10,40, 40);
                yield return new AmazingTestScenario(10,80, 80);
                yield return new AmazingTestScenario(10,160,160);
            }
        }

        [Test, TestCaseSource("InvalidMazes")]
        public void KnownInvalidMazesBehaviour(AmazingTestScenario testScenario)
        {
            try
            {
                AmazingWrapper.GetMazeFor(testScenario);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [UseReporter(typeof(DiffReporter))]
        [Test, TestCaseSource("ValidMazes")]
        public void KnownValidMazesBehaviour(AmazingTestScenario testScenario)
        {
            using(ApprovalResults.ForScenario($"Random seed: {testScenario.RandomSeed}; Width: {testScenario.Width}; Height: {testScenario.Height}"))
            {
                Approvals.Verify(AmazingWrapper.GetMazeFor(testScenario));
            }
        }
    }
}