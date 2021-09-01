using DefaultNamespace;
using View;

namespace ViewModel
{
    public sealed class TimerVM
    {
        private Snake _snake;
        public TimerVM(Snake snake, Timer timer)
        {
            _snake = snake;
            timer.TickTimer += TimerTick;
        }

        public void TimerTick()
        {
            _snake.Move();
        }
    }
}