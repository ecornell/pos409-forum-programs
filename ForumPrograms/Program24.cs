using System;
using System.IO;

namespace ForumPrograms {

    public class Program24 {

        static void Main(string[] args) {
                       
            using (StreamWriter writer = new StreamWriter("test.txt")) {
                writer.WriteLine("This is a test of the StringWriter class.\r\n1\r\n2\r\n3");                
            }

            using (StreamReader reader = new StreamReader("test.txt")) {
                while (!reader.EndOfStream) {        
                    Console.WriteLine(reader.ReadLine());
                }                 
            }

            //--            
            Console.ReadKey();
        }
    }
}