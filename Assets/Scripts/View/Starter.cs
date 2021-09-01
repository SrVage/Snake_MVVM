using System;
using DefaultNamespace;
using UnityEngine;
using ViewModel;

namespace View
{
    public sealed class Starter:MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private GameObject _tailView;
        [SerializeField] private Input _input;

        private void Start()
        {
            var snake = new Snake(3);
            new TimerVM(snake, _timer);
            foreach (var tail in snake.SnakeStructure)
            {
                var tailView = GameObject.Instantiate(_tailView, new Vector3(tail.Position.x, 0, tail.Position.y), Quaternion.identity);
                var moveVM = new MoveVM(tail, _timer);
                tailView.GetComponent<TailView>().Initialize(moveVM);
                if (tail is Head head)
                {
                    var inputVM = new InputVM(head);
                    _input.Initialize(inputVM);
                }
            }
        }
    }
}