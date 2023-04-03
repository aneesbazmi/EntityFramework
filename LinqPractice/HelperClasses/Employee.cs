using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.HelperClasses
{
    internal class Employee
    {
        private string _FirstName;
        private string _LastName;
        private int _age;
        private string _city;
        private string _state;
        private string _country;
        private int _id;

        public Employee(string fname, string lname, int age, string city, string country) {
            FirstName = fname;
            LastName = lname;
            City = city;
            Age = age;
            Country = country;
            Id = 2;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 0;
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Id { get; set;  }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() {   new Employee("anees", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("Ali", "bazmi", 23, "lhr", "pakistan"),
                                            new Employee("hussain", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("irshad", "bazmi", 23, "lhr", "pakistan"),
                                            new Employee("ayesha", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("maryum", "bazmi", 80, "multan", "pakistan"),
                                            new Employee("aliya", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("jhon", "bazmi", 90, "lhr", "pakistan"),
                                            new Employee("nafees", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("arsalan", "bazmi", 23, "multan", "pakistan"),
                                            new Employee("atif", "bazmi", 27, "kwl", "pakistan"),
                                            new Employee("ijaz", "bazmi", 23, "kwl", "pakistan"),
                                            new Employee("shumaila", "bazmi", 23, "multan", "pakistan"),
                                            new Employee("sana", "sana1", 23, "multan", "pakistan")};
        }
        public static string GiveToString(Employee emp)
        {
            

            return emp.FirstName + " "  + emp.LastName + " " + emp.Country + " " + emp.City + " " +  emp.Age;
        }
        public string getLastName()
        {
            return this.LastName;


        }
        
    }
}
