namespace Tests.GoldenMasters
{
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