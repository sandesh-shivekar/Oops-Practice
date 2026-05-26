//using System;

//namespace oops_practice
//{
//    internal class Employee
//    {
//        public int id;
//        public string name;

//        public void work()
//        {
//            Console.WriteLine("Employee is working");
//        }
//    }

//    internal class Manager : Employee
//    {
//        public void manage()
//        {
//            Console.WriteLine("Manager is managing");
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Manager m = new Manager();

//            m.id = 101;
//            m.name = "Sandesh";

//            Console.WriteLine("ID: " + m.id);
//            Console.WriteLine("Name: " + m.name);

//            m.work();   // inherited method
//            m.manage(); // own method
//        }
//    }
//}