using System;
using UnityEngine;
using ViewModel;

namespace View
{
    public sealed class Timer:MonoBehaviour
    {
        private float _moveTime = 1;
        private float _currentTime = 0;
        public event Action TickTimer;
        
        private void Update()
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime <= 0)
            {
                TickTimer?.Invoke();
                _currentTime = _moveTime;
            }
        }
    }
}