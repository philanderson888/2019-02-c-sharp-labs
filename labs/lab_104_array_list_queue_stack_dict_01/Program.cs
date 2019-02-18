using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static List<int> list = new List<int>();
        static Stack<int> stack = new Stack<int>();
        static Queue<int> queue = new Queue<int>();
        static Dictionary<int, int> dictionary = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            // Put 10 numbers in array
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Move items to a list and add 1 
            foreach(int i in myArray)
            {
                list.Add(i+1);
            }
            // Move to stack and add 1
            foreach(int i in list)
            {
                stack.Push(i + 1);
            }
            // Move to a queue and add 1
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(stack.Pop() + 1);
            }
            // Move to dictionary and add 1
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i,queue.Dequeue()+1);
            }
            // Return total of items in dictionary
            int total = 0;
            foreach(int key in dictionary.Keys)
            {
                total += dictionary[key];
            }
            Console.WriteLine(total);
        }

        static void FillArray() {
           
        }
    }
}
