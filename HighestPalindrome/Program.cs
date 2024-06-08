using System;

class Program
{
    static void Main(string[] args)
    {
        // Process Sample 1
        string inputSample1 = "3943";
        int kSample1 = 1;
        string outputSample1 = HighestPalindrome(inputSample1, kSample1, 0, inputSample1.Length - 1);
        Console.WriteLine($"Input: {inputSample1}, k: {kSample1}");
        Console.WriteLine($"Output: {outputSample1}");

        // Process Sample 2
        string inputSample2 = "932239";
        int kSample2 = 2;
        string outputSample2 = HighestPalindrome(inputSample2, kSample2, 0, inputSample2.Length - 1);
        Console.WriteLine($"Input: {inputSample2}, k: {kSample2}");
        Console.WriteLine($"Output: {outputSample2}");
    }

    static string HighestPalindrome(string s, int k, int left, int right)
    {
        if (left >= right)
        {
            if (k < 0) return "-1"; // Not enough changes to make it a palindrome
            return MaximizePalindrome(s, k, 0, s.Length - 1); // Maximize the palindrome
        }

        char[] arr = s.ToCharArray();
        if (arr[left] != arr[right])
        {
            if (k <= 0) return "-1"; // Not enough changes left to make it a palindrome
            char maxChar = (char)Math.Max(arr[left], arr[right]);
            arr[left] = arr[right] = maxChar;
            k--;
        }

        return HighestPalindrome(new string(arr), k, left + 1, right - 1);
    }

    static string MaximizePalindrome(string s, int k, int left, int right)
    {
        if (left > right || k <= 0) return s;

        char[] arr = s.ToCharArray();
        if (arr[left] < '9')
        {
            if ((left == right && k >= 1) || (left != right && k >= 2))
            {
                arr[left] = arr[right] = '9';
                k -= (left == right) ? 1 : 2;
            }
        }

        return MaximizePalindrome(new string(arr), k, left + 1, right - 1);
    }
}