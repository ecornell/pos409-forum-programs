using System.Linq;
using System.Text;

namespace ForumPrograms {
    public class Program28 {
        static void Main(string[] args) {
        }

        public string ReverseText(string text) {

            StringBuilder newText = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--) {
                newText.Append(text[i]);
            }

            return newText.ToString();
        }

    }
}

