using System;
using System.Collections.Generic;

namespace Net6BaseLib.designPatterns.observer;

public class ApplicationSupplier : IObservable<UpdateApplication>
{
    private readonly List<IObserver<UpdateApplication>> _observer;
    public List<UpdateApplication> Applications { get; set; }

    public List<UpdateApplication> GetApplications()
    {
        return Applications;
    }

    public ApplicationSupplier()
    {
        _observer = new List<IObserver<UpdateApplication>>();
        Applications = new List<UpdateApplication>();
    }

    public IDisposable Subscribe(IObserver<UpdateApplication> observer)
    {
        if (!_observer.Contains(observer))
        {
            _observer.Add(observer);

            foreach (var item in GetApplications())
            {
                observer.OnNext(item);
            }
        }

        return new Unsubscriber<UpdateApplication>(_observer, observer);
    }

    public void ApplicationUpdate(string version, string feature, string name){
        var application = new UpdateApplication(version, feature, name);
    }
}