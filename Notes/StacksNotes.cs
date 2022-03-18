using System.Collections;
using System;
using System.Collections.Generic;

public class StacksNotes
{
    /* Notes
                    Stack
                    ------

    Serves as a collection of elements.There are two main operations of stack.

    PUSH - Adds Elements to the collection
    POP - Removes elements from the collection. 

    Stacks works in a Last in, First out (LIFO) manner, it is considered a
    linear structure. The push and pop only happen at one end of the structure. 

    
+-----------------------+                                         +----------------------+
|                       |                                         |                      |
|     Last In           |                                         |    First out         |
|                       |                                         |                      |
|                       +----------+                +------------>|                      |
+-----------------------+          |                |             +----------------------+
                                   |                |
                                   |                |
                                   |                |
                                   |                |
                          +------+ |                |  +-----+
                          | Push | |                |  | Pop |
                          +------+ |                |  +-----+
                                   |                |
                                   |                |
                          +--------+----------------+--------------+
                          |                                        |
                          |   +---------------------------------+  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   +---------------------------------+  |
                          |                                        |
                          |   +---------------------------------+  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   +---------------------------------+  |
                          |                                        |
                          |   +---------------------------------+  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   |                                 |  |
                          |   +---------------------------------+  |
                          |                                        |
                          +----------------------------------------+
    */
    private static string ReverseAString(string input)
    {
        Stack<char> obj = new Stack<char>();
        string outPut = string.Empty;
        if (input != null)
        {
            int inputLen = input.Length;
            for (var i = 0; i < inputLen; i++)
            {
                obj.Push(input[i]);
            }
            while (obj.Count != 0)
            {
                outPut += obj.Pop();
            }
        }
        return outPut;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        // Use this to see execution time.
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        string outputReverseString = ReverseAString(inputString);
        watch.Stop();
        Console.WriteLine("\nReversed string is :" + outputReverseString);
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        Console.Read();
    }
}
