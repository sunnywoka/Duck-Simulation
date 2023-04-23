using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckClass mallard = new MallardDuck();
            mallard.quackPerform();
            mallard.flyPerform();
        }
    }
}
