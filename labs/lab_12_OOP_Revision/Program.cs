﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_OOP_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.field = 0;
            var c = new Child();
            c.field = 0;
        }
    }

    interface IDoSomething { }

    public class Parent {
        // field
        public int field;
    }

    // Inherit from parent
    // Implement an interface
    public class Child : Parent, IDoSomething { }

    // SEALED : NO MORE CHILDREN
    sealed class GrandChild : Child { }

   
}
