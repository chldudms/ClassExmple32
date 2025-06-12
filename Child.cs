using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Child: Parent
    {
        public Child(): base()
        {
            Console.WriteLine("Child constructor called");
        }
        public Child(String input) : base(input)
        {
            Console.WriteLine("Child constructor with input called");
        }

        static void Main(string[] args)
        {
            Child child1 = new Child();
            Child child2 = new Child("Hello");
        }
    }
}
