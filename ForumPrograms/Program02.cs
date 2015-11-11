using System;

namespace ForumPrograms {
    class Program02 {
        static void Main(string[] args) {

            Console.Write("The next meal will be ");

            int currentHour = DateTime.Now.TimeOfDay.Hours;
            if (currentHour < 5) {
                Console.WriteLine("Midnight Snack");
            } else if (currentHour < 9) {
                Console.WriteLine("Breakfast");
            } else if (currentHour < 11) {
                Console.WriteLine("Brunch");
            } else if (currentHour < 13) {
                Console.WriteLine("Lunch");
            } else if (currentHour < 14) {
                Console.WriteLine("Afternoon Snack");
            } else if (currentHour < 16) {
                Console.WriteLine("Supper");
            } else if (currentHour < 24) {
                Console.WriteLine("Night-time Snack");
            }

            Console.ReadKey();
        }
    }
}
