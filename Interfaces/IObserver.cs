namespace DuckReunion.Interfaces
{
    public interface IObserver
    {
        void Subscribe(IObservable observable);
        void Update(IObservable subject);
    }
}
