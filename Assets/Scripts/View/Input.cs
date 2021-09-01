using System;
using DefaultNamespace;
using UnityEngine;
using ViewModel;

namespace View
{
    public sealed class Input:MonoBehaviour
    {
        private InputVM _inputVM;
        
        public void Initialize(InputVM inputVm)
        {
            _inputVM = inputVm;
        }
        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.UpArrow))
            {
                _inputVM.ChangeDirection(Direction.Up);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.DownArrow))
            {
                _inputVM.ChangeDirection(Direction.Down);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.RightArrow))
            {
                _inputVM.ChangeDirection(Direction.Right);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _inputVM.ChangeDirection(Direction.Left);
            }
        }
    }
}