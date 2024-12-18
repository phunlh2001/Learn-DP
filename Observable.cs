using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class Observable : IObservable
    {
        private readonly List<IObserver> observers = new();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Update(this);
            }
        }
    }
}
