using System;


    internal class Program
    {
        static void Main(string[] args)
        {

        //write operation
            Console.WriteLine("Hello dear please mention your Name: ");

        // read operation
        var name=Console.ReadLine();

        //concat operation
        Console.WriteLine("welcome dear " + name);

        //placeHolder operation
        Console.WriteLine("welcome dear {0}", name);


        }
    }

