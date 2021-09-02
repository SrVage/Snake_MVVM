using System;
using DefaultNamespace;
using UnityEngine;

namespace ViewModel
{
    public class AppleVM
    {
        private Apple _apple;
        public event Action<Vector3> ChangeApplePosition;

        public AppleVM(Apple apple)
        {
            _apple = apple;
        }

        public void AppleEat()
        {
            _apple.EatApple();
            ChangePosition();
        }

        private void ChangePosition()
        {
            var newApplePosition = new Vector3(_apple.Position.x, 0, _apple.Position.y);
            ChangeApplePosition?.Invoke(newApplePosition);
        }
    }
}