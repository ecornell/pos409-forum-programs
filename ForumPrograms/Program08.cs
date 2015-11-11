using System;
using System.Collections.Generic;

namespace ForumPrograms {
    class Program08 {

        class Album : IComparable<Album> {
            string Artist { get; set; }
            string Title { get; set; }
            int Year { get; set; }

            public Album(string band, string title, int year) {
                Artist = band;
                Title = title;
                Year = year;
            }

            public int CompareTo(Album other) {
                if (this.Year == other.Year) {
                    if (this.Artist == other.Artist) {
                        return this.Title.CompareTo(other.Title);
                    }
                    return this.Artist.CompareTo(other.Artist);
                }
                return this.Year.CompareTo(other.Year);
            }

            public override string ToString() {
                return this.Year + " - " + this.Artist + " : " + this.Title;
            }
        }
       
        static void Main(string[] args) {

            List<Album> albums = new List<Album>();
            albums.Add(new Album("Clairity", "Alienation", 2015));                        
            albums.Add(new Album("CAZZETTE", "Eject pt. I", 2012));
            albums.Add(new Album("Bat For Lashes", "Two Suns", 2009));
            albums.Add(new Album("Lana DelRey", "Paradise", 2012));
            albums.Add(new Album("Evanescence", "Fallen", 2003));
            albums.Add(new Album("NIN", "Broken", 1992));
            albums.Add(new Album("Agnes Obel", "Philharmonics", 2010));
            albums.Add(new Album("Betty Who", "Somebody Loves You: Remixes", 2014));
            albums.Add(new Album("Lana DelRey", "Born To Die", 2012));

            albums.Sort();

            foreach (var album in albums) {
                Console.WriteLine(album);
            }
            
            Console.ReadKey();

        }
    }
}
