using LinqPractice.HelperClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Grouping<TKey, TElement> : IGrouping<TKey, TElement>
    {
        private readonly TKey key;
        private readonly IEnumerable<TElement> values;

        public Grouping(TKey key, IEnumerable<TElement> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");
            this.key = key;
            this.values = values;
            //IEnumerator<TElement> enumerator = GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var v = enumerator.Current;
            //    Console.WriteLine("herer" + ((Student)v).Name);
            //}
        }

        public TKey Key
        {
            get { return key; }
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Student
    {
        private int id;
        private string name;
        private int age;

        public Student(int id, string name, int age)
        {
            this.id = id;
            Name = name;
            Age = age;

        }

        public String Name { get; set; }
        public int Id { set; get; }
        public int Age
        {
            get { return id; }
            set { age = value; }



        }
        internal class Program
        {
           
            static void Main(string[] args)
            {
                Student std = new Student(1, "anees bazmi", 30);
                std.Name = "sheikh rashid";
                Console.WriteLine(std.age);
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 2, 1, 1 };
                List<Student> students = new List<Student>() {  new Student(1, "anees bazmi",30),
                                                               new Student(2, "ali hussain",30),
                                                                new Student(3, "ahmad hassan",30),
                                                                new Student(4, "jaikant sikhre",30),
                                                                new Student(5, "ali hussain",30),
                                                                new Student(6, "hajra rafique",30),
                                                                new Student(7, "ab",39),
                                                                new Student(8, "ab",32),
                                                                new Student(9, "anees chaudhary",33)
                                                             };

                int[] arr = { 1, 3, 4, 5 };

                 IEnumerable<Student> s = students;
                 Grouping<string, Student > stdGroupOnAge = new Grouping<string, Student>("name", students);

                
                 IEnumerator<Student> enumerator = stdGroupOnAge.GetEnumerator();
                //while(enumerator.MoveNext())
                //{
                //    Student student = enumerator.Current;
                //    Console.WriteLine("herer" + student.Name);
                //}
                //int maxg = students.GroupBy(x => x.Name).Max(x => x.Count());
                //var maxgroup = students.GroupBy((g) => g.Name).Where(x => x.Count() == maxg).Select(x => x).First();
                ////Console.WriteLine(maxgroup);
                //foreach(var v in maxgroup) {
                //    Console.WriteLine(v.Name);
                //    //foreach (Student student in v)
                //    //{
                //    //    Console.WriteLine("\t" + student.Name);
                //    //}
                //}
                //foreach(var s1 in sgroup)
                //{
                //    Console.WriteLine("key is {0}, {1} ",s1.Key, s1.Count());
                //    foreach(Student student in s1)
                //    {
                //        Console.WriteLine("\t" + student.Name);
                //    }
                //}


                //List<int> myList = new List<int>() { 1, 2, 3 };
                //MyMethod(myList);
                //IEnumerable<int> myEnumerable = myList;
                //MyMethod(myEnumerable);

                //GetFirstGroupHighest();
                //LinQOnDictionaryDataStructure();
                //LinQgroupByFunctionInDepth();
                //LinQOrderByAndThenToFunctionInDepth();
                //GroupingAndSorting();
                //MyFunc();


                Console.WriteLine("******************1method starts from here********************");
                LinqAggregateFunction();
                LinqFunctionAll();
                LinqFunctionAny();
                LinqFunctionAverage();
                Console.ReadLine();


            }

            // Method with IEnumerable parameter
            static void MyMethod(IEnumerable<int> sequence)
            {
                foreach (int element in sequence)
                {
                    Console.WriteLine(element);
                }
            }

            // Convert List to IEnumerable
        }
        static void GetFirstGroupHighest()
        {
            List<Student> students = new List<Student>() {  new Student(1, "anees bazmi",30),
                                                               new Student(2, "ali hussain",30),
                                                                new Student(3, "ahmad hassan",30),
                                                                new Student(4, "jaikant sikhre",30),
                                                                new Student(5, "ali hussain",30),
                                                                new Student(6, "hajra rafique",30),
                                                                new Student(7, "ab",39),
                                                                new Student(8, "ab",32),
                                                                new Student(9, "anees chaudhary",33)
                                                             };

           
            var highestGroup = students.GroupBy(x => x.Name).OrderByDescending(x =>x.Count()).ToList();
           // highestGroup.e
            Console.WriteLine("********GetFirstGroupHighest**********");
            if (highestGroup != null)
            {
                foreach(var k in highestGroup)
                {
                   // List<Student> stdsInKey = k.ToList();                    
                    Console.WriteLine(k.Key);
                }
                //Student s = highestGroup.ElementAt(0);
                //Console.WriteLine(highestGroup.ElementAt(0).Name);
            }

        }
        static void LinQOnDictionaryDataStructure()
        {
            Dictionary<string,int> myDict =     new Dictionary<string,int>();

            myDict.Add("key1", 1);
            myDict.Add("key14", 2);
            myDict.Add("key21", 3);
            myDict.Add("key11", 4);
            myDict.Add("key9", 5);
            myDict.Add("key8", 6);
            myDict.Add("key7", 7);

            IEnumerable<KeyValuePair<string, int>> kv = myDict.Where(x => x.Value % 2 == 0);

            List<KeyValuePair<string, int>> keyValuePairs = kv.ToList();

            Console.WriteLine("********LinQOnDictionaryDataStructure**********");

            foreach (KeyValuePair<string, int> item in  keyValuePairs)
            {
                Console.Write(item.Key + " ");
                Console.WriteLine(item.Value);

            }
             
        }
        static void LinQgroupByFunctionInDepth()
        {
            List<Employee> employees = Employee.GetEmployees();
            var GroupByCity = employees.GroupBy(x => x.City).
                                        Select(x => new {
                                                City = x.Key, Employees = x.OrderByDescending(g => g.Age)
                                        });


            var GroupByCity1 = employees.GroupBy(x => x.City).Select(g => new { city = g.Key,
                                                                                       employees = g.OrderByDescending(x=>x.FirstName)});
            foreach (var employeeGroup in GroupByCity1)
            {
                Console.WriteLine("city: {0}",employeeGroup);
                foreach(var emp in employeeGroup.employees)
                {
                    Console.WriteLine(Employee.GiveToString(emp));

                }
            }


        }
        static void LinQOrderByAndThenToFunctionInDepth()
        {
            List<Employee> employees = Employee.GetEmployees();
            var _orderByThen = employees.OrderByDescending(x => x.Age).ThenByDescending(x=>x.FirstName);
           

            foreach (var empSortedByAgethenFirstName in _orderByThen)
            {
                Console.WriteLine(Employee.GiveToString(empSortedByAgethenFirstName));
                
            }


        }
        public static void GroupingAndSorting()
        {
            Console.WriteLine("*********************sorting and grouping*************************");
            List<Employee> employees = Employee.GetEmployees();

            var SortedGroupByCity = employees
                .GroupBy(x => x.City)
                .OrderBy(x => x.Count())
                .Select(g => new {
                city = g.Key,
                SortedEmployees = g.OrderBy(x => x.City)
            });

            foreach (var grp in SortedGroupByCity)
            {
                Console.WriteLine(" city =  {0}", grp.city);
                foreach (var empInSortedOrder in grp.SortedEmployees)
                {
                    Console.WriteLine(empInSortedOrder.FirstName);
                }

            }
        }

        public static void MyFunc()
        {
            IEnumerator itr = Employee.GetEmployees().GetEnumerator();
            while (itr.MoveNext())
            {
                Employee e = itr.Current as Employee;
                Console.WriteLine(e.FirstName);
            }

        }
        public static void LinqAggregateFunction()
        {
        //    suppose i have a list of employees and i want to sum the all the ages of all employees,
        //    we can use Linq aggregate MEthod to do this.

            List<Employee> employees = Employee.GetEmployees();
            var SummedAges = employees.Select(x => x.Age).Aggregate((a, b) => a + b);
            Console.WriteLine("Sum of all ages of All employees are {0} ", SummedAges);
            
        }


        public static void LinqFunctionAll()
        {
            //    suppose i have a list of employees and i want to check whether all my employees are teenage,
            //    we can use Linq All MEthod to do this.

            List<Employee> employees = Employee.GetEmployees();
            var _allTeenager = employees.All(x => x.Age > 18);

            if (_allTeenager)
            {
                Console.WriteLine("All empllyees are teenager");
            }
            else
            {
                Console.WriteLine("be careful all employees are not teenager");
            }

        }
        public static void LinqFunctionAny()
        {
            //    suppose i have a list of employees and i want to check is there a employee who lives in Lhr
            //     and 30 years old.
            //    we can use Linq Any MEthod to do this.

            // lets define a delegate function;
            // we can also do wihtout delegate Function;
            Func<string, int, bool> sltr = delegate (string city, int age ) { if (age >= 30 && city.Equals("lhr")) return true; return false; }; 
            List<Employee> employees = Employee.GetEmployees();
            var _livesInLahore = employees.Select(x => new { ecity = x.City, eage = x.Age }).Any( x=>sltr(x.ecity, x.eage));

            if (_livesInLahore)
            {
                Console.WriteLine("yes there exisrt a record");
            }
            else
            {
                Console.WriteLine("thre does not exist a record");
            }
           


        }
        public static void LinqFunctionAverage()
        {
            // use average function if we want to get the means of the data
            List<Employee> employees = Employee.GetEmployees();
            Console.WriteLine("average age is {0}  ",employees.Average(x => x.Age));
        }

        public static void LinqFunction()
        {
            List<Employee> employees = Employee.GetEmployees();
        }




    }
}
