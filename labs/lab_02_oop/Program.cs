using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();  // syntactic sugar 
            Parent p02 = new Parent();  // regular code
            p01.Age = 10;
            p01.Age = -10;
            Console.WriteLine(p01.Age);

            dynamic x = 10;
            Console.WriteLine(x+1);
            dynamic y = "hello";
            Console.WriteLine(y+1); 
        }
    }

    class Parent {
        // field
        private int X;
        // property
        private string Y { get; set; }       // shorthand
        private string ReadMeOnly { get; }  // read only
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                
            }
        }
        // method

    }

    class Child : Parent {

    }
}
