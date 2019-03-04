using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_121_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class HashSetToExcel

    {
        // 1105
        int[] array = new int[3];
        HashSet<int> hashset = new HashSet<int>();
        LinkedList<int> linkedlist = new LinkedList<int>();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
          
        public Custom HashSetToExcelTest(int a, int b, int c)
        {
            array[0] = a;  array[1] = b; array[2] = c;
            for (int i = 0; i < 2; i++) {
                hashset.Add(array[0] * 2);
            }
            
            return new Custom(-1,-1,-1);
        }
    }

    public class Custom{
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int TimeTaken { get; set; }
        // constructor has same name as class
        public Custom(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

    }
}
