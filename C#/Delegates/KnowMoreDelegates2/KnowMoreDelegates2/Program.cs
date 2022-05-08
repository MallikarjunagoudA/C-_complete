using System;
using System.Collections.Generic;

namespace KnowMoreDelegates2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            emp.Add(new Employee() { id = 1, Name = "mallikarjun", salary = 500000, expirience = 4 }); 
            emp.Add(new Employee() { id = 2, Name = "manu", salary = 450000, expirience = 7 }); 
            emp.Add(new Employee() { id = 3, Name = "sujit", salary = 700000, expirience = 5 }); 
            emp.Add(new Employee() { id = 4, Name = "Gana", salary = 550000, expirience = 8 });

            Employee empll = new Employee();
            empll.PromoteEmp(emp);
        }



    }

    public class Employee
    {
        public int id { get; set; }
        public string  Name { get; set; }
        public  int     salary { get; set; }
        public int expirience { get; set; }

        public void PromoteEmp(List<Employee> emp)
        {
            foreach(Employee empItem in emp)
            {
                if (empItem.expirience > 5)
                {
                    Console.WriteLine(empItem.Name + " Promoted");
                }
            }
        }
    }
}
