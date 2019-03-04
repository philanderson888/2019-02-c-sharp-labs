using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /* 
         * Start a stopwatch
         Pass 3 numbers to an array
         Double numbers and pass to a LINKED LIST
         Double numbers and pass to a HASH SET  *** FASTER THAN LIST ***
         Add 15, to each number, then treble/triple numbers and pass to a DICTIONARY
         Stop the stopwatch.
         Return the test as a CUSTOM OBJECT CONTAINING
            ElapsedTime (integer, will be in milliseconds)
            First number
            Second number
            Third number
        Test passes if stopwatch time less than time passed in (4th variable) (set
            to 10 seconds)
        Not part of the test 
        Output all values to .csv text file and append to existing file.
            DATETIME STAMP
            INPUT 4 PARAMS
            OUTPUT 4 PARAMS
        Finally launch excel to read this file using Process.Start...

             
             
             
             
             
             
             */


        [TestCase(10,20,30,10)]
        public void HashSetExcelTest1(int a, int b, int c, int d)

        {
            Assert.Pass();
        }
    }
}