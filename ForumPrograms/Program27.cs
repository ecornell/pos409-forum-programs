using System;
using System.Text.RegularExpressions;

namespace ForumPrograms {
    public class Program27 {        
        static void Main(string[] args) {

            string inputText, outputText;

            inputText = "Smith, James\t13211231234\t19650901\r\nFields, Terri\t14247855828\t19740223\r\nJones, Fred\t19872384876\t19821123";

            Console.WriteLine(inputText +"\n\n");

            string namePattern = @"(\w+), (\w+)";
            string phonePattern = @"(\d{1})(\d{3})(\d{3})(\d{4})";
            string dobPattern = @"(\d{4})(\d{2})(\d{2})";

            outputText = Regex.Replace(inputText, namePattern, "$2 $1");
            outputText = Regex.Replace(outputText, phonePattern, "$1-$2-$3-$4");
            outputText = Regex.Replace(outputText, dobPattern, "$2/$3/$1");
            
            Console.WriteLine(outputText + "\n\n");

            //--            
            Console.ReadKey();
        }
    }
}

