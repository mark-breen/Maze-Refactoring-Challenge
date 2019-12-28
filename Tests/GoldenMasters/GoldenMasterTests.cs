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