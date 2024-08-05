using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test.Delegates
{
    public delegate string GreetingDelegate(string name);
    class AnonymousMethod
    {
        public static string Greetings(string name)
        {
            return "Hello " + name + "a very good morning";
        }
        public static void main()
        {
            GreetingDelegate greeting = (name) =>
            {
                return "Hello " + name + "a very good morning";
            };
            Console.WriteLine(greeting("shubham"));

        }
    }
}
