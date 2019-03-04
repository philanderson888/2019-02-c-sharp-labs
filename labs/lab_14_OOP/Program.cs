using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Blueprint b01 = new Blueprint();
            House h01 = new House();                  // INSTANTIATE
            // b01 and h01 are OBJECTS
            h01.Length = 3;
            h01.numFloors = 2;
            h01.numWindows = 10;
            if (h01.numWindows == 10) { }
        }
    }

    class Blueprint
    {
        public string field01;
        public int field02;
    }
    // INSTRUCTIONS TO BUILD HOUSE
    class House
    {
        public int numFloors;
        public int numWindows;
        public double Length { get; set; }
    }
}
