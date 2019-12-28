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
        private static IEnumerable<AmazingTestScenario> ValidMazes
        {
            get
            {
                yield return new AmazingTestScenario(0,5, 20);
                yield return new AmazingTestScenario(0,10, 20);
                yield return new AmazingTestScenario(0,15, 20);
                yield return new AmazingTestScenario(0,20, 20);
                yield return new AmazingTestScenario(0,40, 40);
                yield return new AmazingTestScenario(0,80, 80);
                yield return new AmazingTestScenario(0,160,160);
                
                yield return new AmazingTestScenario(1,5, 20);
                yield return new AmazingTestScenario(1,10, 20);
                yield return new AmazingTestScenario(1,15, 20);
                yield return new AmazingTestScenario(1,20, 20);
                yield return new AmazingTestScenario(1,40, 40);
                yield return new AmazingTestScenario(1,80, 80);
                yield return new AmazingTestScenario(1,160,160);
                
                yield return new AmazingTestScenario(10,5, 20);
                yield return new AmazingTestScenario(10,10, 20);
                yield return new AmazingTestScenario(10,15, 20);
                yield return new AmazingTestScenario(10,20, 20);
                yield return new AmazingTestScenario(10,40, 40);
                yield return new AmazingTestScenario(10,80, 80);
                yield return new AmazingTestScenario(10,160,160);
            }
        }

        [UseReporter(typeof(DiffReporter))]
        [Test, TestCaseSource("ValidMazes")]
        public void AssertOnGoldenTemplates(AmazingTestScenario testScenario)
        {
            using(ApprovalResults.ForScenario($"Random seed: {testScenario.RandomSeed}; Width: {testScenario.Width}; Height: {testScenario.Height}"))
            {
                Approvals.Verify(AmazingWrapper.GetMazeFor(testScenario.RandomSeed, testScenario.Width, testScenario.Height));
            }
        }
        
        internal class AmazingTestScenario
        {
            public AmazingTestScenario(int randomSeed, int width, int height)
            {
                RandomSeed = randomSeed;
                Width = width;
                Height = height;
            }
            
            public int RandomSeed { get; }

            public int Width { get; }

            public int Height { get; }
        }
    }
}