using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsNotebook
{
    //Need a function with only one input string
    delegate void StringProcessor(string input);
    class DelegateCore
    {
        //backup functions
        public static void PrintString(string s) {
            Console.WriteLine("Static invoke, String is" + s);
        }
        public void PrintObject(object o) {
        }
        static void Main(string[] args)
        {
            StringProcessor proc1, proc2;
            proc1 = new StringProcessor(PrintString);
            InstanceMethods instance = new InstanceMethods();
            proc2 = new StringProcessor(instance.PrintString);
            proc1("Hello World");
            proc2("Hello World");
            Console.ReadKey();
        }
    }
    class InstanceMethods {
        public void PrintString(string s){ Console.WriteLine("instance invoke, String is" + s); }
    }
}
