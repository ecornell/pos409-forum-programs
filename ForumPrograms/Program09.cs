using System;
using System.Linq;
using System.Collections.Generic;

namespace ForumPrograms {
    class Program09 {
       
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


           var results = albums
               .Where(album => album.Year > 2005 && album.Artist.StartsWith("C"))
               .OrderBy(album => album.Year);

           
           foreach (var album in results) {
               Console.WriteLine(album);
           }

           Console.ReadKey();

       }
        
       class Album {
           public string Artist { get; set; }
           public string Title { get; set; }
           public int Year { get; set; }

           public Album(string band, string title, int year) {
               Artist = band;
               Title = title;
               Year = year;
           }

           public override string ToString() {
               return this.Year + " - " + this.Artist + " : " + this.Title;
           }
       }

    }
}
