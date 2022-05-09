using System;

namespace KTToString
{
    public class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            Console.WriteLine(Convert.ToString(a));

            overString os = new overString();
            os.firstName = "mallikarjun";
            os.LastName = "arahunasi";

            Console.WriteLine(Convert.ToString(os)); //if i wil not override the tostring method then i will get result like overString.Tostring

        }
    }

    public class overString 
    {

        public string firstName { get; set; }
        public string LastName { get; set; }



        public override string ToString()
        {
            return firstName + "," + LastName;
        }

    }

}
