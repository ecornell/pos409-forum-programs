using System;

namespace ForumPrograms {
    
    class DelegateChaining {

        // Delegate definition
        private delegate void functionDelegate(ref string s);
        private functionDelegate functions;
        
        // 
        private void ToUpperCase(ref string s) {
            s = s.ToUpper();
        }

        private void AddSpaces(ref string s) {
            string output = "";
            foreach (var c in s) {
                output += c + " ";
            }
            s = output;
        }
              
        
        private void Run() {

            // Register delegate methods
            functions += ToUpperCase;
            functions += AddSpaces;
            functions += delegate(ref string s) {
                s =  "{" + s + "}";
            };

            //

            string input = "testing";
            functions(ref input); // invoke all registered methods

            Console.WriteLine(input);
            
        }

        static void Main(string[] args) {
            DelegateChaining program = new DelegateChaining();
            program.Run();
            Console.ReadKey();
        }
    }
}
