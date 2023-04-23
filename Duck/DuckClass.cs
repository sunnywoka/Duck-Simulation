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

    abstract public void display();

    public void quackPerform() {
        flyBehavior.fly();
    }

    public void flyPerform() {
        quackBehavior.quack();
    }

    public void swimPerform() {
        System.Console.WriteLine("I am swimming");
    }
    }


}

