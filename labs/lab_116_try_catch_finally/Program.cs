using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_116_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                try {
                    throw new Exception("\nHey this is a serious error. Fix it!!!\n");
                }
                catch (Exception e){
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally { }
            }
            catch (Exception e) {
                Console.WriteLine("\n\tHey - thrown exception has been caught at an upper level\n");
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("\nAll Done");
            }
        }
    }
}
