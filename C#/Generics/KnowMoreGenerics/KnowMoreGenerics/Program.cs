using System;

namespace KnowMoreGenerics
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //with generics
            bool res = Checks.AllEqulWithGeneric<string>("a", "a");


        }

        public static class Check 
        {
            //with out generics
            public static bool AllEqul(int value1, int value2)
            {
                return value1 == value2;
            }
        }

        

        public static class Checks
        {
            //with generics
            public static bool AllEqulWithGeneric<T>(T value1, T value2) //here T might any name
            {
                return value1.Equals(value2);
            }
        }
    }
     
}
