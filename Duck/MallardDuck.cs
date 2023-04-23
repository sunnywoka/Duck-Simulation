using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public class MallardDuck : DuckClass {

    public MallardDuck() {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

        public override void display()
        {
            System.Console.WriteLine("I am Mallard duck.");
        }
    }


}