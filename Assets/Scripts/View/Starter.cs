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
        [SerializeField] private GameObject _appleView;
        private Snake _snake;

        private void Start()
        {
            var apple = new Apple();
            var appleVM = new AppleVM(apple);
            var appleView = GameObject.Instantiate(_appleView, new Vector3(apple.Position.x, 0, apple.Position.y),
                Quaternion.identity);
            appleView.GetComponent<AppleView>().Initialize(appleVM);
            appleView.GetComponent<AppleView>().EatApple += CreateTail;
            _snake = new Snake(3);
            new TimerVM(_snake, _timer);
            foreach (var tail in _snake.SnakeStructure)
            {
                var tailView = GameObject.Instantiate(_tailView, new Vector3(tail.Position.x, 0, tail.Position.y), Quaternion.identity);
                var moveVM = new MoveVM(tail, _timer);
                tailView.GetComponent<TailView>().Initialize(moveVM);
                if (tail is Head head)
                {
                    var inputVM = new InputVM(head);
                    _input.Initialize(inputVM);
                    tailView.AddComponent<HeadView>();
                }
            }
        }

        private void CreateTail()
        {
            var tail = _snake.AddTail();
            var tailView = GameObject.Instantiate(_tailView, new Vector3(tail.Position.x, 0, tail.Position.y), Quaternion.identity);
            var moveVM = new MoveVM(tail, _timer);
            tailView.GetComponent<TailView>().Initialize(moveVM);
        }
    }
}