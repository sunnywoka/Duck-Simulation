using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck
{
    public class Mute : QuackBehavior {
    public void quack(){
        Console.WriteLine("<<Silence>>");
    }
    }
}