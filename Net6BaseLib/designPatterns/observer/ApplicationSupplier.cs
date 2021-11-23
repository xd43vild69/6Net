using System;
using System.Collections.Generic;

namespace Net6BaseLib.designPatterns.observer;

public class ApplicationSupplier : IObservable<UpdateApplication>
{
    private readonly List<IObserver<UpdateApplication>> _observers;
    public List<UpdateApplication> SoftwareInstalled { get; set; }

    public List<UpdateApplication> GetApplications()
    {
        return SoftwareInstalled;
    }

    public ApplicationSupplier()
    {
        _observers = new List<IObserver<UpdateApplication>>();
        SoftwareInstalled = new List<UpdateApplication>();
    }

    public IDisposable Subscribe(IObserver<UpdateApplication> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);

            foreach (var item in GetApplications())
            {
                observer.OnNext(item);
            }
        }

        return new Unsubscriber<UpdateApplication>(_observers, observer);
    }

    public void ApplicationUpdate(string version, string feature, string name)
    {
        var application = new UpdateApplication(version, feature, name);
        foreach (var item in _observers)
            item.OnNext(application);
    }
}