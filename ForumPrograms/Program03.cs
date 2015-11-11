using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ForumPrograms {
    
    class Program03 {

        class Dish {
            public bool clean = false;
        };

        static void Main(string[] args) {
                      
            List<Dish> dishes = new List<Dish>();

            // Initialize an array with all the dishes
            int numberDishes = 100;
            for (int i = 0; i < numberDishes; i++) {
                dishes.Add(new Dish());
            }

            // Wash Dishes in Parallel
            Parallel.ForEach(dishes, dish => {
                dish.clean = true;
            });
            
            // Check for dirty dishes
            var dirtyDishes = dishes.Where(dish => dish.clean == false); // Linq query that returns only the unclean dishes
            
            Console.WriteLine("Number of dirty dishes - {0}", dirtyDishes.LongCount());
                        
            Console.ReadKey();
        }
    }
}
