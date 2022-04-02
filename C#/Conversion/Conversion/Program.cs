using System;


    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("implicit conversion");
        //implicit conversion
        int a = 10;

        float b = a;
        Console.WriteLine("a and b are: {0} {1}",a,b);


        //explicit conversion two ways==> type cast and framework convert class
        Console.WriteLine("explicit conversion two ways==> type cast and framework convert class");
        Console.WriteLine(" type cast ");


        //type cast
        float c = 10.65f;
        Console.WriteLine("c {0}", c);
        int d = (int)c;
        Console.WriteLine("c and d {1} {1}",c,d);

        Console.WriteLine(" convert class");


        //convert class
        float f = 14.54f;
        int e = Convert.ToInt32(c);
        Console.WriteLine("f and d {0} {1}", f, e);



        //use of the Parse() and TryParse()

        //parse--it will throw exception if the value can not  able to do convert to int
        string num = "123";

        int g = int.Parse(num);
        Console.WriteLine("parse of string num to int g is {0}", g);

        //tryParse --will bool value. and it wil not give any exception
        int res = 0;
        string number = "12453fs";
        int.TryParse(number, out res);
        Console.WriteLine("tryparse will return bool {0}", res);

      

       
        }
    }

