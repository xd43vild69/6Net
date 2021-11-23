namespace Net6BaseLib.designPatterns.observer;

sealed class ApplicationMonitor : IObserver<UpdateApplication>
{
    private IDisposable _cancellation;
    private readonly string _name;

    public ApplicationMonitor(string name)
    {
        _name = name;
    }

    public void Subscribe(ApplicationSupplier supplier)
    {
        _cancellation = supplier.Subscribe(this);
    }

    public void Unsubscriber()
    {
        _cancellation.Dispose();
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception ex)
    {
        throw new NotImplementedException();
    }

    public void OnNext(UpdateApplication update)
    {
        System.Console.WriteLine($"Update:{update.Name} on {_name}");
    }
}