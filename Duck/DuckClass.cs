using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public abstract class DuckClass {
    public FlyBehavior flyBehavior;
    public QuackBehavior quackBehavior;

    public DuckClass() {}

    public virtual void diaplay() {}

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

