using System;
using System.Collections.Generic;
using System.IO;

namespace ForumPrograms {

    class Program17 {

        struct HighScores {
            public HighScores(long score, string name) {
                this.score = score;
                this.name = name;
            }
            public long score;
            public string name;
        }

        static void Main(string[] args) {

            Program17 program = new Program17();

            List<HighScores> highScores = program.getHighScores();

            // Display highscores from file
            Console.WriteLine("  High Scores\n==============");
            foreach (var highScore in highScores) {
                Console.WriteLine("{0,10:N0} {1}", highScore.score, highScore.name);
            }

            //--            
            Console.ReadKey();
        }


        private List<HighScores> getHighScores() {

            List<HighScores> highScores = new List<HighScores>();

            using (StreamReader reader = new StreamReader(@"highscores.dat")) {
                string line;
                string[] scoredata;
                while ((line = reader.ReadLine()) != null) {
                    if (line.Contains("|")) {
                        scoredata = line.Split('|');
                        highScores.Add(new HighScores(long.Parse(scoredata[0]), scoredata[1]));
                    }
                }
            }

            return highScores;

        }

    }
}
