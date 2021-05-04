using System;


/* We discussed that delegates are used to reference any methods that has the same signature as that of the delegate. In other words, you can call a method that can be referenced by a delegate using that delegate object.

Anonymous methods provide a technique to pass a code block as a delegate parameter.Anonymous methods are the methods without a name, just the body.

    You need not specify the return type in an anonymous method; it is inferred from the return statement inside the method body.*/
delegate void NumberChanger(int n);
namespace AnonymousMethods
{
    class TestDelegate
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x) {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //calling the delegate using the anonymous method 
            nc(10);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods 
            nc(5);

            //instantiating the delegate using another named methods 
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods 
            nc(2);
            Console.ReadKey();
        }
    }
}