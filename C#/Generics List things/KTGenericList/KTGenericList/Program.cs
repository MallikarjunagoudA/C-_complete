using System;
using System.Collections.Generic;
using System.Linq;

namespace KTGenericList
{
    public class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer()
            {
                custID = 1,
                custName = "arjun"
            };
            Customer c2 = new Customer()
            {
                custID = 2,
                custName = "Rarjun"
            };
            Customer c3 = new Customer()
            {
                custID = 3,
                custName = "Karjun"
            };
            Customer c5 = new Customer()
            {
                custID = 3,
                custName = "Karjun"
            };
            List<Customer> cust = new List<Customer>();


            //list of methods which are we are used with the LIST
            //add => adding the data at the last of the list
            cust.Add(c1);
            cust.Add(c2);
            cust.Add(c2);

            //insert => help to add the data anywhere in the list
            cust.Insert(0, c3);



            foreach (Customer c in cust)
            {
                Console.WriteLine("customer id is {0} and customer name is {1}", c.custID, c.custName);
            }


            //indexOf => helps to get the index of the value
            int IndexIs = cust.IndexOf(c3);
            Console.WriteLine("c3 index is {0}",IndexIs);
            int IndexIswithExtra = cust.IndexOf(c3,0,3);
            Console.WriteLine("c3 index is {0}", IndexIswithExtra);


            //contains => check the value available if avail=>true else => false

            if (cust.Contains(c3))
            {
                Console.WriteLine("c3 obj containls in the list");
            }
            else
            {
                Console.WriteLine("c3 obj is not containls in the list");

            }

            //Exist() => check the value available in the list along with some conditions.

            if (cust.Exists(c => c.custName.Contains("arjudn")))
            {
                Console.WriteLine("c3 obj exist in the list");
            }
            else
            {
                Console.WriteLine("c3 obj is not exist in the list");

            }


            //Find() => return the value which matched first.
            Customer cc =cust.Find(c => c.custName.Contains("jun"));
            Console.WriteLine("find method result {0}",cc.custName);



            //FindLast() => return the value which matched last.
            Customer ccc = cust.FindLast(c => c.custName.Contains("jun"));
            Console.WriteLine("findLast method result {0}", ccc.custName);




            //FindAll() => return all the values which matched.
            List<Customer> cccc = cust.FindAll(c => c.custID !=0);
            foreach (Customer c in cccc)
            {
                Console.WriteLine("findall method result {0}", c.custID, c.custName);
            }


            //FindIndex() 
            Console.WriteLine("findIndex method result {0}", cust.FindIndex(c => c.custName.Contains("jun")));

            //FindLastIndex() 
            Console.WriteLine("FindLastIndex method result {0}", cust.FindLastIndex(c => c.custName.Contains("jun")));


#region convert
            //convert to array
            Customer[] arrCust = cust.ToArray();
            foreach (Customer c in arrCust)
            {
                Console.WriteLine("Toarray()  method result {0}", c.custID, c.custName);
            }

            //convert to list from array

            Customer[] arrCust1 = new Customer[2];
            arrCust1[0] = c1;
            arrCust1[1] = c2;
            List<Customer> Cust1 = arrCust1.ToList();
            foreach (Customer c in Cust1)
            {
                Console.WriteLine("ToList()  method result {0}", c.custID, c.custName);
            }


            //convert to dictionary

            Dictionary<int, Customer> dict = cust.ToDictionary(x => x.custID);

            #endregion


            //AddRange() => add the list to the existing list @end

            cust.AddRange(cccc);


            //GetRange() => get the range of items

            List<Customer> getRangeValue = cust.GetRange(0, 3);


            //insertRange() => insert the list at a specified index

            cust.InsertRange(3, cccc);



            //reomve() => remove the item from list based on conditions

            cust.Remove(c1);


            //removeAt => remove at the specified index

            cust.RemoveAt(0);


            //removeAll => removeall  based on conditions

            cccc.RemoveAll(c =>c.custID>0);


            //clear() => delete all

            cust.Clear();




            //sort() 
            List<int> numbers = new List<int>() { 2, 6, 5, 3, 8, 9, 0, 1 };

            numbers.Sort();

            //reverse()
            numbers.Reverse();

            //sort for complex type
            //cust.sort() not possible until expicitly use compareTo

            cust.Sort();

            //trueForAll()

            cust.TrueForAll(c => c.custName.Contains("ru"));

            //AsReadOnly()

            cust.AsReadOnly();

            //trimExcess();

            cust.TrimExcess();
            //jai Hind











        }
    }

    public class Customer
    {

        public int custID { get; set; }
        public string custName { get; set; }

        public int compareTo(Customer obj)
        {
            return this.custID.CompareTo(obj.custID);
        }

    }
}
