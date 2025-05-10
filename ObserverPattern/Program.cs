﻿using DesignPattern.ObserverPattern.lib;

namespace DesignPattern.ObserverPattern;

public class Program
{
    public static void Main()
    {
        var subject = new ConcreteSubject();
        
        var observer1 = new ConcreteObserver("Observer 1");
        var observer2 = new ConcreteObserver("Observer 2");
        var observer3 = new ConcreteObserver("Observer 3");
        
        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.Attach(observer3);
        
        subject.SetState(10);
        subject.SetState(20);
        
        subject.Detach(observer2);
        
        subject.SetState(30);
    }
}