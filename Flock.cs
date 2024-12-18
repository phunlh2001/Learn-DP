using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class Flock : IQuackable, IObservable
    {
        private readonly List<IQuackable> _quackers = new();
        private readonly List<IObserver> _observers = new();
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
            Notify();
        }
    }
}
