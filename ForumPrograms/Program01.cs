using System;
using System.Linq;

namespace ForumPrograms {
    class Program01 {
        static void Main(string[] args) {

            Console.Write("Calculate the Scrabble point value of a word\n");

            String input;

            do {
                Console.Write("\nEnter word: ");
                input = Console.ReadLine();

                int pointValue = 0;

                foreach (var letter in input.ToUpper()) {
                    if ("EAIONRTLSU".Contains(letter)) {
                        pointValue += 1;
                    } else if ("DG".Contains(letter)) {
                        pointValue += 2;
                    } else if ("BCMP".Contains(letter)) {
                        pointValue += 3;
                    } else if ("FHVWY".Contains(letter)) {
                        pointValue += 4;
                    } else if ("K".Contains(letter)) {
                        pointValue += 5;
                    } else if ("JX".Contains(letter)) {
                        pointValue += 8;
                    } else if ("QZ".Contains(letter)) {
                        pointValue += 10;
                    } else {
                        // invalid letter
                    }
                }

                Console.Write("\n" + input + " has the point value of " + pointValue + "\n");
                Console.Write("\nCalculate another word (y/n) : ");
                input = Console.ReadLine();

            } while (input.Equals("y"));
        }
    }
}
