using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            // try - code which can possibly crash
            try
            {
                // file read as string
                string data01 = File.ReadAllText("file.txt");
            }
            // specific : HANDLING THE EXCEPTION
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Phil says make that file!");
            }
            // always run regardless
            finally
            {
                Console.WriteLine("and make it quick");
            }

        }
    }
}
