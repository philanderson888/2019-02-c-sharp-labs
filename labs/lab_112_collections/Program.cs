using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Collections();
        }
    }

    public class Collections {

        /*
         *  Receive 3 numbers
         *  
         *  Put these 3 numbers into array
         *  
         *  Output numbers,  double each one and store in STACK
         *  
         *  Repeat ie Output numbers, double and store in QUEUE
         *  
         *  Output numbers, SQUARE THEM then store in List<int>
         *  
         *  Add up numbers in the List<int> and return total
         *  
         *          
        */

        public double Collections20MinuteLab(int num1, int num2, int num3)
        {
            int[] myArray = new int[] { num1, num2, num3 };
            var myStack = new Stack<int>();
            var myQueue = new Queue<int>();
            var myList = new List<int>();


            foreach(int i in myArray)
            {
                myStack.Push(i * 2);
            }

            for (int i = 0; i < 3; i++)
            {
                myQueue.Enqueue(myStack.Pop()*2);
            }

            for (int i = 0; i < 3; i++)
            {
                var item = myQueue.Dequeue();
                myList.Add(item * item);
            }

            // add up

            double total = 0;
            foreach(int i in myList)
            {
                total += i;
            }

            return total;
        }

    }
}
