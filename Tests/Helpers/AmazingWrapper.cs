using System;

namespace Tests.Helpers
{
    internal class AmazingWrapper
    {
        internal static string GetMazeFor(int randomSeed, int width, int height)
        {
            Amazing.random = new Random(randomSeed);
            Amazing.doit(width, height);
            return Amazing.result;
        }
    }
}