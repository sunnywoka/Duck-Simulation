using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public abstract class DuckClass {
    FlyBehavior flyBehavior;
    QuackBehavior quackBehavior;

    public DuckClass() {}

    public abstract void diaplay() {}

    public void quackPerform() {
        flyBehavior.fly();
    }

    public void flyPerform() {
        quackBehavior.quack();
    }

    public void swimPerform() {
        Console.WriteLine("I am swimming");
    }
    }


}

