using System;
using Tests.GoldenMasters;

namespace Tests.Helpers
{
    internal class AmazingWrapper
    {
        internal static string GetMazeFor(AmazingTestScenario testScenario)
        {
            Amazing.random = new Random(testScenario.RandomSeed);
            Amazing.doit(testScenario.Width, testScenario.Height);
            return Amazing.result;
        }
    }
}