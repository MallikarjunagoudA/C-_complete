using System;

namespace MethodsTypes
{
    internal class Program
    {

        //value parameter 
        public static void add(int a, int b)
        {
            a = 9;
            int sum = (a + b);
            Console.WriteLine("sum ={0}", sum);
        }

        //reference parameter using ref keyword
        public static void add(ref int a,ref int b)
        {
            a = 7;
            int sum = (a + b);
            Console.WriteLine("sum ={0}", sum);
        }

        //for out parameter
        public static void calculate( int a,  int b, out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
        }
      
        public static void parameterArray(int x, params int[] numbers)
        {
            Console.WriteLine("length {0}", numbers.Length);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int c = 4, d=5;

            Console.WriteLine("value parameter");
            add(c, d);  //for value parameter

            Console.WriteLine("reference parameter");
            add(ref c, ref d);  //for reference parameter


            Console.WriteLine("out parameter");
            //for out parameter
            int total = 0;
            int prod = 0;
            calculate( c,  d, out total, out prod);
            Console.WriteLine("toal and prod is  {0} {1}", total, prod);

            //for parameter arrays


            Console.WriteLine("parameter arrays");
            //parameterArray(1);
            int[] arr = new int[3] { 1, 2, 3 };
            //parameterArray(2, arr);
            parameterArray(4, 11, 22, 33, 44, 5);

            Console.WriteLine("Hello World!");
        }
    }
}
