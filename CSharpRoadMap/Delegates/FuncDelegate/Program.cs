using System;
using System.ComponentModel;

namespace FuncDelegate
{
    // "public delegate TResult Func<in T, out TResult>(T arg);" // The last parameter in the angle brackets <> is considered the return type, and the remaining parameters are considered input parameter types

    // "public delegate TResult2 Func<in T1,in T2, out TResult2>(T1 arg1, T2 arg2);"  // A Func delegate with two input parameters and one out parameters will be represented 
    
    class Program
    {
       

        static void Main(string[] args)
        {
            // Func is a generic delegate included in the System namespace. It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.
            

            Func<int, int, int> Formulas = Sum; // You can assign any method to the above func delegate that takes two int parameters and returns an int value.
            int result = Formulas(10, 6);
            Console.WriteLine(result);
            int x = 20 + Formulas(10, 6);
            //Console.WriteLine(x);

            Console.WriteLine("-----------");


            Formulas += Subtract;

            Console.WriteLine(Formulas(10,6));
            Console.WriteLine("-----------------------");

            //A Func delegate type can include 0 to 16 input parameters of different types. However, it must include an out parameter for the result. For example, the following Func delegate doesn't have any input parameter, and it includes only an out parameter.

            /* You can assign an anonymous method to the Func delegate by using the "delegate" keyword.*/
            Func<int> getRandomNumber = delegate {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };  /* delegate {.....}*/
            Console.WriteLine(getRandomNumber()); // Calling randomnumber method by way of delegate


        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

    //  Points to Remember :


    /* -Func is built-in delegate type.
       -Func delegate type must return a value.
       -Func delegate type can have zero to 16 input parameters.
       -Func delegate does not allow ref and out parameters.
       -Func delegate type can be used with an "anonymous method" or "lambda expression." */
}
