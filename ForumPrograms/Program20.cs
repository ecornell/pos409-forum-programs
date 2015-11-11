using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ForumPrograms {

    class Program20 {

        static void Main(string[] args) {

            var states = new List<string> { 
                "Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware",
                "Florida","Georgia","Hawaii","Idaho","Illinois","Indiana","Iowa","Kansas","Kentucky",
                "Louisiana","Maine","Maryland","Massachusetts","Michigan","Minnesota","Mississippi",
                "Missouri","Montana","Nebraska","Nevada","New Hampshire","New Jersey",
                "New Mexico","New York","North Carolina","North Dakota","Ohio","Oklahoma","Oregon",
                "Pennsylvania","Rhode Island","South Carolina","South Dakota","Tennessee","Texas",
                "Utah","Vermont","Virginia","Washington","West Virginia","Wisconsin","Wyoming" };

            var results = from state in states
                             where (state.Length >= 10)
                             select state;

            Console.WriteLine("State names with 10 or more charactors: {0}\n", results.Count() );

            foreach (var state in results) {
                Console.WriteLine(state);
            }
            
            //--            
            Console.ReadKey();
        }
    }
}
