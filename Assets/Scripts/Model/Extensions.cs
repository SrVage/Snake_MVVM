namespace DefaultNamespace
{
    public static class Extensions
    {
        public static Vector2 Right(this Vector2 vector)
        {
            vector.x += 1;
            vector.y += 0;
            return vector;
        }
        public static Vector2 Left(this Vector2 vector)
        {
            vector.x -= 1;
            vector.y += 0;
            return vector;
        }
        public static Vector2 Up(this Vector2 vector)
        {
            vector.x += 0;
            vector.y += 1;
            return vector;
        }
        public static Vector2 Down(this Vector2 vector)
        {
            vector.x += 0;
            vector.y -= 1;
            return vector;
        }
    }
}