using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public class FlyNoWay : FlyBehavior {
    public void fly(){
        System.Console.WriteLine("I cannot fly");
    }
    }

}