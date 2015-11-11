using System;
using System.Collections.Generic;

namespace ForumPrograms {
    class Program11 {

        class StudentC {
            public string Name { get; set; }
        }

        struct StudentS {
            public string Name;
        }

        static void Main(string[] args) {

            StudentC studentC = new StudentC();
            studentC.Name = "Jane";

            ByValueTestClass(studentC); // passed by ref

            Console.WriteLine(studentC.Name); // Prints - Jane-ByValue

            ByReferenceTestClass(ref studentC); // passed by ref - ref keyword is redundant

            Console.WriteLine(studentC.Name); // Prints - Jane-ByValue-ByReference

            //--

            StudentS studentS = new StudentS();
            studentS.Name = "John";

            ByValueTestStruct(studentS); // passed by value

            Console.WriteLine(studentS.Name); // Prints - John

            ByReferenceTestStruct(ref studentS); // passed by ref

            Console.WriteLine(studentS.Name); // Prints - John-ByReference
        
            //-
            Console.ReadKey();
        }


        static void ByValueTestClass(StudentC student) {
            student.Name += "-ByValue";
        }

        static void ByReferenceTestClass(ref StudentC student) {
            student.Name += "-ByReference";
        }

        static void ByValueTestStruct(StudentS student) {
            student.Name += "-ByValue";
        }

        static void ByReferenceTestStruct(ref StudentS student) {
            student.Name += "-ByReference";
        }
    }

    



}
