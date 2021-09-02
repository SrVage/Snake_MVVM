using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class Snake
    {
        public List<Tail> SnakeStructure;

        public Snake(int count)
        {
            SnakeStructure = new List<Tail>();
            Vector2 temp = new Vector2(0, 0);
            for (int i = 0; i < count; i++)
            {
                Tail tail;
                if (i == 0)
                {
                    tail = new Head(new Vector2(-i, 0), temp);
                }
                else
                {
                    tail = new Tail(new Vector2(-i, 0), temp);
                }
                temp = tail.Position;
                SnakeStructure.Add(tail);
            }
        }

        public Tail AddTail()
        {
            Vector2 temp = SnakeStructure[SnakeStructure.Count-1].Position;
            var tail = new Tail(new Vector2(temp.x, temp.y), temp);
            SnakeStructure.Add(tail);
            return tail;
        }

        public void Move()
        {
            Vector2 temp = new Vector2(0, 0);
            foreach (var Tail in SnakeStructure)
            {
                if (Tail is Head head)
                {
                    switch (head.Direction)
                    {
                        case Direction.Right: head.Position = head.Position.Right();
                            break;
                        case Direction.Left: head.Position=head.Position.Left();
                            break;
                        case Direction.Up: head.Position=head.Position.Up();
                            break;
                        case Direction.Down: head.Position=head.Position.Down();
                            break;
                    }
                    temp = head.Position;
                }
                else
                {
                    Tail.Position = Tail.NextPosition;
                    Tail.NextPosition = temp;
                    temp = Tail.Position;
                }
            }
        }
    }
}