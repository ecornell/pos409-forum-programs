using System;

namespace ForumPrograms {
    class Program05 {
        static void Main(string[] args) {

            bool checkValue = false;

            // Entry check
            for (int i = 0; i < 10 && checkValue; i++) {
                Console.WriteLine("In for loop");
            }

            // Entry check
            while (checkValue) {
                Console.WriteLine("In while loop");
            }

            // Exit check
            do {
                Console.WriteLine("In do/while loop");
            } while (checkValue);

            Console.ReadKey();
        }
    }
}

// ==Output==
// In do/while loop

