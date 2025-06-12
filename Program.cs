﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample32
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;

            public void CountParent()
            {
                Console.WriteLine("CountParent() called");
                counter++;
            }

            public Parent() {  Console.WriteLine("Parent()");}
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child():base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }

        
        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parentA = new Parent();
            Child child = new Child();

            parentA.CountParent();
            child.CountParent();
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}