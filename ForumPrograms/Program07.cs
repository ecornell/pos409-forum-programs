using System;
using System.Collections.Generic;

namespace ForumPrograms {
    class Program07 {

        public interface IInhabited {
            long getPopulationDensity();
        }

        class Planet {
            public string Name { get; set; }
            public long Size { get; set; }
        }

        class Mars : Planet {
            public Mars() {
                Name = "Mars";
                Size = 1231232;
            }
        }

        class Earth : Planet, IInhabited {

            public long HumanPopulation { get; set; }

            public Earth() {
                Name = "Earth";
                Size = 510072000;
                HumanPopulation = 7300000000;
            }

            public long getPopulationDensity() {
                return HumanPopulation / Size;
            }
        }

        static void Main(string[] args) {

            Planet[] planets = new Planet[] { new Earth(), new Mars() };

            foreach (var planet in planets) {
                if (planet is IInhabited) {
                    Console.WriteLine(
                            planet.Name + 
                            " is inhabited with a population density of " +
                            ((IInhabited)planet).getPopulationDensity() +    // cast planet to interface to access common method
                            " humans per sq/km"
                        );
                }
            }

            Console.ReadKey();

        }
    }
}
