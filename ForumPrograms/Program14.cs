using System;

namespace ForumPrograms {

    class InputHandler {
        public InputHandler(Publisher pub) {
            pub.InputEvent += HandleInputEvent;
        }
        void HandleInputEvent(object sender, char input) {
            Console.WriteLine("InputHandler received input: {0}", input);
        }
    }

    class Publisher {

        public event EventHandler<char> InputEvent;

        protected virtual void OnInputEvent(char input) {
            EventHandler<char> handler = InputEvent;
            if (handler != null) {
                handler(this, input);
            }
        }

        static void Main(string[] args) {

            Publisher iPublisher = new Publisher();

            // Register a handler from a separate class
            InputHandler iHandler1 = new InputHandler(iPublisher);

            // Register a handler using an anonymous method
            iPublisher.InputEvent += (object sender, char inChar) => {
                Console.WriteLine("Anonymous handler received input: {0}", inChar);
            };

            char input;
            do {
                input = Console.ReadKey(true).KeyChar;
                iPublisher.OnInputEvent(input); // fire event actions
            } while (input != 'x');

        }
    }
}
