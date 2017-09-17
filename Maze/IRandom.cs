using System;

namespace Maze
{
    public interface IRandom
    {
        int RandomIntFor(int count);
    }
    public class AmazingRandom : IRandom
    {
        private readonly Random _random;

        public AmazingRandom(int seed)
        {
            _random = new Random(seed);
        }

        public int RandomIntFor(int count)
        {
            return (int)(count * _random.NextDouble()) + 1;
        }
    }
}