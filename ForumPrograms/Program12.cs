using System;
using System.Collections.Generic;
using System.Reflection;

namespace ForumPrograms {
           
    class Program12 {
        
        class ClassA {

            public ClassA() {
                Console.WriteLine("ClassA Constructor");
            }

            ~ClassA() {
                Console.WriteLine("ClassA Deconstructor");
            }

        }

        class ClassB : ClassA {
            public ClassB() {
                Console.WriteLine("ClassB Constructor");
            }

            ~ClassB() {
                Console.WriteLine("ClassB Deconstructor");
            }
        }



        //public int Add(int a, int b) {
        //    return a + b;
        //}        

        static void Main(string[] args) {
            //Program12 c = new Program12();
            //MethodInfo methodInfo = c.GetType().GetMethod("Add");
            //int r = (int)methodInfo.Invoke(c,new object[] { 2, 2 });
            //Console.WriteLine(r); //4
            
            ClassB b = new ClassB();
            b = null;

            GC.Collect();  // Force 

            //-
            Console.ReadKey();
        }        
    }
}


// https://msdn.microsoft.com/en-us/library/66x5fx1b.aspx
// https://msdn.microsoft.com/en-us/library/xe0c2357.aspx