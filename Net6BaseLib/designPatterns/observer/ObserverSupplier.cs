using System;
using System.Collections.Generic;

namespace Net6BaseLib.designPatterns.observer;

public class ObserverSupplier : IObservable<UpdateApplication>
{
    private readonly List<IObserver<UpdateApplication>> _observer;
    public List<UpdateApplication> Applications { get; set; }

    public List<UpdateApplication> GetApplications()
    {
        return Applications;
    }

    public ObserverSupplier()
    {
        _observer = new List<IObserver<UpdateApplication>>();
        Applications = new List<UpdateApplication>();
    }

    public IDisposable Subscribe(IObserver<UpdateApplication> observer)
    {
        return null;
    }
}