using System;
using System.Collections.Generic;

namespace program_latihan_algo
{
    class Program
    {
        static void Main()
        {
           Stack<int> stack = new Stack<int>();

			
            // CREATE(S)
           while (stack.Count <= 5)
           {
           int item = stack.Count;
           stack.Push(item);
           if (stack.Count <= 5)
           {
           Console.WriteLine("Top(S): \t" + item);
           Console.WriteLine("NOEL(S): \t" + stack.Count);
           }
        }
            foreach (int item in stack)
            {
             Console.Write(item + " ");  
            }
            Console.WriteLine(" ");

            // REPEAT
            do
            {
                stack.Pop();
                if (stack.Count >= 2)
            {
                    Console.WriteLine("Top(S): \t" + stack.Peek());
                    Console.WriteLine("NOEL(S): \t" + stack.Count);
            }
        }
        while (stack.Count != 0);
           
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
            Console.WriteLine(" ");

            Console.WriteLine("ISEMPTY(S):" + (stack.Count ==0));
            }
	}
}