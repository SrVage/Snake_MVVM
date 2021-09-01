using DefaultNamespace;

namespace ViewModel
{
    public sealed class InputVM
    {
        private Head _head;

        public InputVM(Head head)
        {
            _head = head;
        }

        public void ChangeDirection(Direction direction)
        {
            _head.ChangeDirection(direction);
        }
    }
}