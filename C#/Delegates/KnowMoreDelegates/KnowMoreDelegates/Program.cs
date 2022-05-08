using System;

namespace KnowMoreDelegates
{
    // Delegate is the type safe function pointer.
    //defining the delegates
    public delegate void HelloDelegate(string str);
    public class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate dlt = new HelloDelegate(Hello);
            dlt("hello this is call from delegate ");
        }

        public static void Hello(string msz)
        {
            Console.WriteLine("too all THis is Hello static method"+msz);
        }
    }
}
