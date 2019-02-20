using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class arraylist
    {
        public int arraylistMethod(int a, int b, int c, int d)
        {
            // accept 4 integers
            /*
             * put to ARRAY
             * extract ==> double ==> put to QUEUE
             * extract ==> double ==> put to STACK
             * extract ==> square ==> put to DICTIONARY
             * put to ARRAYLIST 
             * extract and get the sum of the items and return this sum
             */

            var array = new int[] { a, b, c, d };
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            var dict = new Dictionary<int, int>();
            var arraylist = new ArrayList();

            foreach(var i in array)
            {
                queue.Enqueue(i*2);
            }

            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(queue.Dequeue()*2);
            }

            for (int i = 0; i< array.Length; i++)
            {
                var square = stack.Pop();
                square *= square;

                dict.Add(i, square);
            }

            foreach(var item in dict)
            {
                arraylist.Add(item.Value);
            }

            int total = 0;
            foreach(var item in arraylist)
            {
                total += (int)item;
            }


            return total;
        }
    }
}
