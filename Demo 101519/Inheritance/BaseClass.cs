using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        // field inheritance 
        private int basePrivateInt;
        protected int baseProtectedInt;

        // Constructors for field inheritance (set the values)
        public BaseClass() { }
        public BaseClass(int privateInt, int protectedInt)
        {
            this.basePrivateInt = privateInt;
            this.baseProtectedInt = protectedInt;
        }

        // methods inheritance
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");
        }

        // use virtual to override 
        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
            Console.WriteLine();
        }
        
    }
}
