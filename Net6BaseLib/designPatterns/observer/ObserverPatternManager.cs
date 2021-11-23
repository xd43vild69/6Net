namespace Net6BaseLib.designPatterns.observer;

public class ObserverPatternManager
{
    public ObserverPatternManager(){
        var supplier = new ApplicationSupplier();
        var observer1 = new ApplicationMonitor("monitor1");
        var observer2 = new ApplicationMonitor("monitor2");

        supplier.ApplicationUpdate("v1", "f1", "n1");
        observer1.Subscribe(supplier);

        supplier.ApplicationUpdate("v2", "f2", "n2");
        observer2.Subscribe(supplier);      

        observer2.Unsubscriber();
        
         
    }
}