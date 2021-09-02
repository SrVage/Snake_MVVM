using System;

namespace DefaultNamespace
{
    public sealed class Apple
    {
        public Vector2 Position;
        private Random rnd;
        public Apple()
        {
            rnd = new Random();
            Position = new Vector2(rnd.Next(0, 5), rnd.Next(0, 5));
        }

        public void EatApple()
        {
            Position = new Vector2(rnd.Next(0, 5), rnd.Next(0, 5));
        }
    }
}