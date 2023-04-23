using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Duck {
    FlyBehavior flyBehavior;
    QuackBehavior quackBehavior;

    public Duck() {}

    public abstract void diaplay() {}

    public void quackPerform() {
        flyBehavior.fly();
    }

    public void flyPerform() {
        quackBehavior.quack();
    }

    public void swimPerform() {
        Console.Write("I am swimming");
    }





}

