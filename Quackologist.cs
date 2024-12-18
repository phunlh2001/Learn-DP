using DuckReunion.Interfaces;

namespace DuckReunion
{
    public class Quackologist : IObserver
    {
        public void Subscribe(IObservable observable)
        {
            observable.Attach(this);
        }

        public void Update(IObservable subject)
        {
            Console.WriteLine($"Quackologist: {subject} just quacked.");
        }
    }
}
