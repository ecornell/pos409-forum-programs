using System;

namespace ForumPrograms {
    class Program06 {
        static void Main(string[] args) {
            
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("== For Loop ==");

            for (int i = 0; i < days.Length; i++) {
                Console.WriteLine(days[i]);
            }

            Console.WriteLine("== ForEach Loop ==");

            foreach (var day in days) {
                Console.WriteLine(day);
            }

            Console.ReadKey();

        }
    }
}
