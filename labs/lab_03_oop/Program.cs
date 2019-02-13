using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent("Bill",22);
            var p02 = new Parent("Bill");
            var p03 = new Parent(age: 22, name: "Bill");  // named parameters
            p01.Name = "Bill";
            p01.Name = "New name";
        }
    }
    class Parent {
        private int _dob;       // PRIVATE FIELD, lower case, _start
        public string Name { get; set; }      // PUBLIC PROPERTY
        public int Age { get; set; }
        public Parent() { }   // default constructor
        public Parent(string name)
        {
            this.Name = name;
        }
        public Parent (string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
    
}
