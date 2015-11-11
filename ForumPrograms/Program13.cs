using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ForumPrograms {    
    class Program13 {
        static void Main(string[] args) {

            Random rnd = new Random();

            List<int> students = new List<int> { 1, 2, 3, 4, 5 };

            // Perform a long-running tasks against each studen in Parallel
            Parallel.ForEach(students, studentID => {

                Thread.Sleep(1000 * rnd.Next(1,3)); // Simulate complex task - 1-3 sec plause
                Console.WriteLine("Finished task for studentID - {0}", studentID);
            
            });
            
            //-
            Console.ReadKey();
        }
    }
}
// https://msdn.microsoft.com/en-us/library/system.threading.tasks.parallel(v=vs.110).aspx

// -- Output --
// Finished task for studentID - 2
// Finished task for studentID - 5
// Finished task for studentID - 4
// Finished task for studentID - 1
// Finished task for studentID - 3
