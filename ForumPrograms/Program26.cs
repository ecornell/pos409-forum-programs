using System;
using System.Diagnostics;

namespace ForumPrograms {

    public class Program26 {

        static Random rnd = new Random();

        static void Main(string[] args) {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine(rollDice());
            }
        }

        static int rollDice() {

            int d = rnd.Next(0, 7);

            Debug.Assert(d >= 1, "Dice value: " + d);
            Debug.Assert(d <= 6, "Dice value: " + d);

            return d;

        }
    }
}

