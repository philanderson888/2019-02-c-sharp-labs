using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.ForEach(item => { Console.WriteLine(item); });
            myList.ForEach((i) => { });
        }
    }
}
