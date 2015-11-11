using System;
using System.Collections;
using System.Collections.Generic;

namespace ForumPrograms {

    public class Program22 {

        static void Main(string[] args) {

            // Stack - A LIFO collection

            Stack<string> stack = new Stack<string>();

            stack.Push("A");  // Push adds to the stack
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            Console.WriteLine(stack.Peek()); // D - Peek returns the last added value without removing it

            Console.WriteLine(stack.Pop()); // D - Pop returna the last added value and removes it

            Console.WriteLine(stack.Peek());  // C
 
       
            // Queue - A FIFO collection

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("a"); // Enqueue adds to the queue
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");

            Console.WriteLine(queue.Peek()); // a - Peek returns the beginning value without removing it

            Console.WriteLine(queue.Dequeue()); // a - Dequeue returns the beginning value and removes it

            Console.WriteLine(queue.Peek()); // b 

            //--            
            Console.ReadKey();
        }
    }
}
