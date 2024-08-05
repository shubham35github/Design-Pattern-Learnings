using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Delegates
{
    internal class Delegate
    {
        public delegate string GreetingDelegate(string name);
        delegate void CalDelegate(int x, int y);
        delegate string SayDelegate(string s);
        void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void SubNum(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        void MulNum(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static string SayHello(string s)
        {
            return "hello" + s;
        }
       /* static void Main(string[] args)
        {
            Delegate del = new Delegate();
            CalDelegate calDelegate = del.AddNum;
            calDelegate += del.SubNum;
            calDelegate += del.MulNum;

            calDelegate(5, 2);

            SayDelegate sayDelegate = new SayDelegate(SayHello);
            string str = sayDelegate("shubham");
            //string str=Delegate.SayHello("Shubham");
            Console.WriteLine(str);
            GreetingDelegate greeting = (name) =>
            {
                return "Hello " + name + "a very good morning";
            };
            Console.WriteLine(greeting("shubham"));
            Console.ReadLine();

        }*/
    }

}
