using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public class MallardDuck : DuckClass {

    public MallardDuck() {
        quackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public void display(){
        Console.WriteLine("I am Mallard duck.");
    }
    }


}