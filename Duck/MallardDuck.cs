using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MallardDuck : Duck {

    public MallardDuck() {
        quackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public void display(){
        Console.Write("I am Mallard duck.");
    }
    

}