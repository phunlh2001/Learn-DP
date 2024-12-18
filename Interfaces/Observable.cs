namespace DuckReunion.Interfaces
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Notify();
    }
}
