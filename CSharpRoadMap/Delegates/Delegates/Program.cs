using System;

namespace Delegates
{
    public delegate void MyDelegate(string message);

    public delegate T MyIntDelegate<T>(T i);
   
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delA = ClassA.MethodA;
            delA("Alrgiht");
            MyIntDelegate<int> delA2 = ClassA.MethodA2; // we clarify the type of valur when create instance of delegate "<int>"
            delA2(3);
            int sayi2 = 8;
            int toplam = sayi2 + delA2(4);
            Console.WriteLine(toplam);

            MyDelegate delA3 = ClassA.MethodA3;
            InvokeDelegate(delA);
            MyDelegate delMulti = delA + delA3;
            delMulti("Loving you is a new loosing");
            MyDelegate delA4Delegate = ClassA.MethodA4;
            delMulti += delA4Delegate; // added a new method to delMulti
            delMulti("hooov"); 
            delMulti -= delA4Delegate; // Deleted a DelA4 method from delMulti
            delMulti("Bazen bana gelir gider seni terketmelerrrr");
            InvokeDelegate(delMulti);
            Console.WriteLine("------------------");
            delMulti += delA4Delegate; // Added MethodA4 again to delMulti
            InvokeDelegate(delMulti); // Invoke delMulti

        }

        static void InvokeDelegate(MyDelegate del)
        {
            del("Hello World");
        }
        
    }

    

    public class ClassA
    {
       public static void MethodA(string m)
        {
            Console.WriteLine("MethodA isimli Method delegate tarafından çağırıldı ve mesaj: "+ m);
        }

       public static int MethodA2(int i)
       {
           return i * 3;
       }

       public static void MethodA3(string m)
       {
           Console.WriteLine("MethodA3 isimli Method delegate tarafından çağırıldı ve mesaj: " + m);
       }
       public static void MethodA4(string m)
       {
           Console.WriteLine("MethodA4 isimli Method delegate tarafından çağırıldı ve mesaj: " + m);
        }
    }

    //Points to Remember :


    /* -Delegate is the reference type data type that defines the signature.
       -Delegate type variable can refer to any method with the same signature as the delegate.
       -Syntax: [access modifier] delegate [return type][delegate name]([parameters])
       -A target method's signature must match with delegate signature.
       -Delegates can be invoke like a normal function or Invoke() method.
       -Multiple methods can be assigned to the delegate using "+" or "+=" operator and removed using "-" or "-=" operator. It is called multicast delegate.
       -If a multicast delegate returns a value then it returns the value from the last assigned target method.
       -Delegate is used to declare an event and anonymous methods in C#.   */
}
