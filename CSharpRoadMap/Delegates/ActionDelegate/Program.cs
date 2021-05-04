using System;

namespace ActionDelegate
{public delegate int Print(int val);
    class Program
    {
        //Action is a delegate type defined in the System namespace.An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void return type.

        //public delegate int Print(int val);
        static void Main(string[] args)
        {
            Action<string> action = new Action<string>(Print);
            action("Hi");
            //    Print prnt = ConsolePrint;
            //    prnt(10);
            //    var result = 20 + prnt(23);
            //    Console.WriteLine(result);

        }

        //public static void Invokedel(Print print)
        //{
        //    print(24);
        //}
        //static void ConsolePrint(int i)
        //{
        //    return i;
        //}
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
