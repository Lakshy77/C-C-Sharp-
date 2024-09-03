using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Constructor{
    public class Person {
        public string name;
        public int age;
        //CONSTRUCTOR-it is called whenever object is created
        // public Person(){
        //     name = "Unknown";
        //     age = 0;
        // }
        public Person(string _name, int _age){
            name = _name;
            age = _age;
        }

        public void GetDetails(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    public class Program{
        public static void Main(string[] args){
            // Person person1 = new Person();
            // person1.GetDetails();
            Person person1 = new Person("Lakshy",20);
            person1.GetDetails();

        }
    }
}