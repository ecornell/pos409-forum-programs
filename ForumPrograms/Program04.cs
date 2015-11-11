using System;

namespace ForumPrograms {
    class Program04 {
        static void Main(string[] args) {

            Console.WriteLine("Conditional check using a conditional OR");

            if (checkIfZero(0) || checkIfZero(1)) {  // The second operand is not evaluated
                Console.WriteLine("Condition 1 met\n");
            } else {
                Console.WriteLine("Condition 1 not met\n");
            }

            Console.WriteLine("Conditional check using a binary OR");

            if (checkIfZero(0) | checkIfZero(1)) { // The second operand is evaluated
                Console.WriteLine("Condition 2 met\n");
            } else {
                Console.WriteLine("Condition 2 not met\n");
            }

            Console.ReadKey();
        }

        static private bool checkIfZero(int input) {
            Console.WriteLine("-> checkIfZero invoked - " + input);
            return input == 0 ? true : false;  // ternary operator
        }

    }
}
