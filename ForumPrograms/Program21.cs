using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ForumPrograms {
        
    public class Program21 {
        
        public class Album {
            public string Artist { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public Album() { } // Parameterless construction required for serialization
            public Album(string band, string title, int year) {
                Artist = band;
                Title = title;
                Year = year;
            }
        }

        static void Main(string[] args) {
            
            List<Album> albums = new List<Album>();
            albums.Add(new Album("Clairity", "Alienation", 2015));
            albums.Add(new Album("CAZZETTE", "Eject pt. I", 2012));
            albums.Add(new Album("Bat For Lashes", "Two Suns", 2009));
            albums.Add(new Album("Lana DelRey", "Paradise", 2012));

            //

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Album>));
            StreamWriter streamWriter = new StreamWriter("albums.xml");
            xmlSerializer.Serialize(streamWriter, albums);
                                   
            //--            
            Console.ReadKey();
        }
    }
}
