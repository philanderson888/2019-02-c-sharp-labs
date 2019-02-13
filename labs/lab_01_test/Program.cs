using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "hello";

            Console.WriteLine(someString[0]);  //h

            var charArray = someString.ToCharArray();

            // invoke new = 'constructor'
            var object1 = new Object();
            int[] myArray = new int[100];

            // literal
            var object2 = new 
            {
                name="hi",
                age=22,
                dob="21/09/1968"
            };

            byte b = 128;      //    1000 0000
            byte bMin = 0;
            byte bMax = 255;

            byte[] buffer = new byte[4000];

            Console.ReadLine();

            
        }
    }
}
