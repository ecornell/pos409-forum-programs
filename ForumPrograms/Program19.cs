using System;
using System.Collections;

namespace ForumPrograms {

    class Program19 {
        
        static void Main(string[] args) {

            Hashtable states = new Hashtable();
            states.Add("AL", "Alabama");
            states.Add("AK", "Alaska");
            states.Add("AZ", "Arizona");
            states.Add("AR", "Arkansas");
            states.Add("CA", "California");
            // repeat for remaining 45 states

            // Lookup a single key 
            Console.WriteLine("AZ is the abbreviation for {0}\n", states["AZ"]);


            // iterate through all keys within the hashtable and display the associated value
            foreach (var key in states.Keys) {
                Console.WriteLine("{0} - {1}", key, states[key]);
            }            

            //--            
            Console.ReadKey();
        }        
    }
}
