using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Sample 1
        string input1 = "{ [ ( ) ] }";
        Console.WriteLine($"Input: {input1}\nOutput: {IsBalanced(input1)}\n");

        // Sample 2
        string input2 = "{ [ ( ] ) }";
        Console.WriteLine($"Input: {input2}\nOutput: {IsBalanced(input2)}\n");

        // Sample 3
        string input3 = "{( ( [ ] ) [ ] ) [ ] }";
        Console.WriteLine($"Input: {input3}\nOutput: {IsBalanced(input3)}\n");
    }

    static string IsBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            switch (c)
            {
                case '{':
                case '[':
                case '(':
                    stack.Push(c);
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') return "NO";
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') return "NO";
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') return "NO";
                    break;
            }
        }
        return stack.Count == 0 ? "YES" : "NO";
    }
}