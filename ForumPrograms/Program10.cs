using System;
using System.Collections.Generic;

namespace ForumPrograms {


    

    class Program10 {

        private class PClass {
        
        }

        static void Main(string[] args) {

            PClass pclass = new PClass();
            System.Type type = pclass.GetType();
            Console.WriteLine(pclass.GetType().IsPublic);



            //delegate x = x => 5 + 5; //
            //delegate MySub(double x); MySub ms = delegate(double y) { y *y; }
            //x => x * x;
            //delegate MySub(); MySub ms = x * x;


            
            //float f = (float)d;
            //if (float.IsInfinity(f)) throw new OverflowException();

            double d = -1E55;
            System.Type myType = d.GetType();


            

            //--

            //checked {
            //    long l = 123456789012345;
            //    int i = (int)l;
            //}


            //--

            //string s1 = "          ";
            //string s2 = new string(new char[] {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '});
            //string s3 = new string(' ', 10);
            //string s4 = "".Space(10);

            // --

            //string intput = "123";
            //int output;
            //if (int.TryParse(intput, out output)) {
            //    Console.WriteLine("Successfully parsed input");
            //} else {
            //    Console.WriteLine("Failed to parsed input");
            //}

            //--

            //List<IPrintable> list = new List<IPrintable>();
            //list.Add(new Adder(1, 1));
            //list.Add(new Subtractor(4, 1));
            //list.Add(new Message("TESTING 123"));

            //foreach (var item in list) {

            //    item.printOutput();

            //}

            Console.ReadKey();

        }


        interface IPrintable {
            void printOutput();
        }

        abstract class Calculator : IPrintable {
            protected long _value1;
            protected long _value2;
            protected abstract long performCalulation();
            public abstract void printOutput();
        }

        class Adder : Calculator {

            public Adder(long value1, long value2) {
                _value1 = value1;
                _value2 = value2;
            }

            override protected long performCalulation() {
                return _value1 + _value2;
            }

            override public void printOutput() {
                Console.WriteLine(_value1 + " + " + _value2 + " = " + performCalulation());
            }

        }

        class Subtractor : Calculator {

            public Subtractor(long value1, long value2) {
                _value1 = value1;
                _value2 = value2;
            }

            override protected long performCalulation() {
                return _value1 - _value2;
            }

            override public void printOutput() {
                Console.WriteLine(_value1 + " - " + _value2 + " = " + performCalulation());
            }
        }

        class Message : IPrintable {
            private string _message;

            public Message(string message) {
                _message = message;
            }

            public void printOutput() {
                Console.WriteLine(_message);
            }
        }

    }
}
