using System;


//two reference variable are pointing to the 2 diff object reference points and they both have the the same values but the 
//-- equals method will return  the false when we compare the both, there the over Ride of the Equals method will come to picture.
namespace KTOverRideEqaulMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.firstName = "jhon";
            c1.LastName = "jobin";

            Customer c2 =new Customer();
            c2.firstName = "jhon";
            c2.LastName = "jobin";

            Console.WriteLine(c1.Equals(c2));

        }
    }

    public class Customer
    {

        public string firstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(obj.GetType() != typeof(Customer))
            {
                return false;
            }
            return this.firstName == ((Customer)obj).firstName && this.LastName == ((Customer)obj).LastName;
        }

        //here we are override the equals method so we are getting the warnging to override the GetHashcode

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
