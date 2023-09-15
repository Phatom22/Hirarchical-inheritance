using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hirarchical_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.WriteLine(obj.info());
            Console.ReadLine();
        }
    }

    class A  //base class
    {
        public string msg()
        {
            return "this is A class Method";
        }
    }
    class B : A
    {
        public string info()
        {
            msg();
            return "this is B class Method";
        }
        class C : A
        {
            public string getinfo()
            {
                msg();
                return "this is B class Method";
            }
        }
    }
}
