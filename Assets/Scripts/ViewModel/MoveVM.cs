using System;
using DefaultNamespace;
using UnityEngine;
using View;

namespace ViewModel
{
    public sealed class MoveVM
    {
        private Tail _tail;
        public event Action<Vector3> MoveTail;

        public MoveVM(Tail tail, Timer timer)
        {
            _tail = tail;
            timer.TickTimer += Move;
        }

        public void Move()
        {
            var position = new Vector3(_tail.Position.x, 0, _tail.Position.y);
            MoveTail?.Invoke(position);
        }
    }
}