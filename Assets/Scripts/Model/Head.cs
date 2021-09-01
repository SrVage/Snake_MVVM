namespace DefaultNamespace
{
    public sealed class Head:Tail
    {
        public Direction Direction;
        public Head(Vector2 position, Vector2 nextPosition) : base(position, nextPosition)
        {
            Direction = Direction.Right;
        }

        public void ChangeDirection(Direction direction)
        {
            if (Direction == Direction.Up)
            {
                if (direction == Direction.Down)
                    return;
            }
            if (Direction == Direction.Down)
            {
                if (direction == Direction.Up)
                    return;
            }
            if (Direction == Direction.Left)
            {
                if (direction == Direction.Right)
                    return;
            }
            if (Direction == Direction.Right)
            {
                if (direction == Direction.Left)
                    return;
            }

            Direction = direction;
        }
    }
}