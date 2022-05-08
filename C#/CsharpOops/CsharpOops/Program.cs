using System;


public interface Icustomer1
{
    void Print2();
}
public interface Icustomer2
{
    void Print2();
}

public class MyClass : Icustomer1, Icustomer2
{
   public void print1()
    {
        Console.WriteLine("print1");
    }
   public void Print2()
    {
        Console.WriteLine("print1");
    }
}

public class Program
    {
        static void Main(string[] args)
        {

        MyClass mc = new MyClass();
        mc.print1();


            Console.WriteLine("Hello World!");
        }
    }

