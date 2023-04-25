using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEthodAndReturnType
{
    public class MethodAndReturnType
    {
        //Method without parameter.
        public void Method()
        {
            Console.WriteLine("Method Without Parameter");
        }
        //Method With Parameter
        public void MethodOne(int x)
        {
            Console.WriteLine($"Method Without Parameter : {x}");
        }
        //Method With Return Type.
        public int MethodTwo()
        {
            return 10;
        }
        //Method With Return type String.
        public string MethodThree()
        {
            return "Shreya ma'am";
        }
        //Method With Bool Return Type
        public bool MethodFour()
        {
            return true;
        }
    }
}
