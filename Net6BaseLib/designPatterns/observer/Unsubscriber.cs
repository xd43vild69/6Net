namespace Net6BaseLib.designPatterns.observer;

public class Unsubscriber<UpdateApplication> : IDisposable
{
    private readonly List<IObserver<UpdateApplication>> _observers;
    private readonly IObserver<UpdateApplication> _observer;

    internal Unsubscriber(List<IObserver<UpdateApplication>> observers, IObserver<UpdateApplication> observer)
    {
        _observers = observers;
        _observer = observer;
    }

    public void Dispose()
    {
        if (_observers.Contains(_observer)) _observers.Remove(_observer);
    }

}